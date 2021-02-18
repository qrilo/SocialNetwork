using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.BLL.Contracts;
using SocialNetwork.BLL.DTO_s;
using SocialNetwork.WEB.ViewModels;
using SocialNetwork.WEB.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.WEB.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public ProfileController(IUserService userService,
            IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("id{id}")]
        public async Task<IActionResult> Index(int id)
        {
            if (string.IsNullOrEmpty(id.ToString()))
            {
                return NotFound();
            }

            var dto = await _userService.GetUserAsync(id);

            if (dto == null)
            {
                return BadRequest("Error");
            }
            var model = _mapper.Map<UserDTO, UserViewModel>(dto);
            
            if (dto.Id == Convert.ToInt32(User.FindFirst("UserId").Value))
            {
                model.ActionType = ActionType.MyProfile;
            }
            else
            {
                model.ActionType = ActionType.NotMyProfile;
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (string.IsNullOrEmpty(Convert.ToString(id)))
            {
                return NotFound();
            }

            if (Convert.ToInt32(User.FindFirst("UserId").Value) != id)
            {
                return RedirectToAction("Edit", new { id = Convert.ToInt32(User.FindFirst("UserId").Value) });
            }

            var dto = await _userService.GetUserAsync(id);
            var model = _mapper.Map<UserDTO, UserViewModel>(dto);
            model.Birthday = new DateTime(2000, 1, 1);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserViewModel model)
        {
            if (model.Birthday < new DateTime(1900, 1, 1) || DateTime.Now.Year - model.Birthday.Year <= 5)
            {
                ModelState.AddModelError("", "Invalid birthday");
                return View(model);
            }

            var dto = _mapper.Map<UserViewModel, UserDTO>(model);

            await _userService.UpdateUserAsync(dto);

            return View();
        }


        //[HttpGet("friends")]
        //public async Task<IActionResult> Friends(int id)
        //{
            
        //    return View();
        //}
        
    }
}
