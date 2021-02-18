using SocialNetwork.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialNetwork.WEB.ViewModels
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Enter email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter password")]
        [DataType(DataType.Password)]
        [MaxLength(16, ErrorMessage = "Maximum length of 16 character")]
        [MinLength(6, ErrorMessage = "Minimum length of 8 character")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Repeat password")]
        [Compare("Password", ErrorMessage = "Password doesn't match")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Surname")]
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
     // public Sex Sex { get; set; }
    }
}
