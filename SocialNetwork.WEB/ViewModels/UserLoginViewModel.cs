using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.WEB.ViewModels
{
    public class UserLoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
