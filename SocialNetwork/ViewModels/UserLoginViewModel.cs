using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.WEB.ViewModels
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Enter email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter password")]
        public string Password { get; set; }
    }
}
