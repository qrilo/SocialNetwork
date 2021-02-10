using SocialNetwork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.DTO_s
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
     // public DateTime Birthday { get; set; }
        public string Surname { get; set; }
     // public Sex Sex { get; set; }
     // public Role Role { get; set; }
    }
}
