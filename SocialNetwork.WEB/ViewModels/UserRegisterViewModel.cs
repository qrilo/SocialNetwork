using SocialNetwork.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.WEB.ViewModels
{
    public class UserRegisterViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
     // public DateTime Birthday { get; set; }
     // public Sex Sex { get; set; }
    }
}
