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

        [HttpGet("profile/{id}")]
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
        
    }
}
