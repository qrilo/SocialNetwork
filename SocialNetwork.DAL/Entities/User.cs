using SocialNetwork.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Sex { get; set; }
        public Role Role { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string EmailConfirmationToken { get; set; }
    }
}
 