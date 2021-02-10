using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SocialNetwork.BLL.Contracts;
using SocialNetwork.BLL.DTO_s;
using SocialNetwork.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialNetwork.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;
        public AccountController(IMapper mapper,
            IAuthService authService)
        {
            _authService = authService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            var model = new UserLoginViewModel();

            return  View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _authService.GetIsUserExistsAsync(model.Email);
                if (result == false)
                {
                    return Content("User doesn't exists");
                }

                var dto = _mapper.Map<UserLoginViewModel, UserLoginDTO>(model);
                var loginResult = await _authService.TryLoginUserAsync(dto);

                if (loginResult.Logged)
                {
                    await Authenticate(loginResult.UserDTO);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username and (or) password");
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new UserRegisterViewModel();
 //           model.Birthday = new DateTime(2000, 1, 1);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                //if (model.Birthday < new DateTime(1900, 1, 1) || DateTime.Now.Year - model.Birthday.Year <= 5)
                //{
                //    ModelState.AddModelError("", "Invalid birthday");
                //    return View(model);
                //}

                var userExist = await _authService.GetIsUserExistsAsync(model.Email);

                if (userExist)
                {
                    return Content("User already exists");
                }

                var dto = _mapper.Map<UserRegisterViewModel, UserDTO>(model);
                await _authService.TryRegisterUserAsync(dto);

                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        private async Task Authenticate(UserDTO userDTO)
        {
            var claims = new List<Claim>
           {
              new Claim(ClaimsIdentity.DefaultNameClaimType, userDTO.Email),
              // new Claim(ClaimsIdentity.DefaultRoleClaimType, userDTO.Role.ToString())
            };  

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
