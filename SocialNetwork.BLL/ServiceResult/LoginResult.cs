using SocialNetwork.BLL.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.ServiceResult
{
    public class LoginResult
    {
        public UserDTO UserDTO { get; set; }
        public bool Logged { get; set; }
    }
}
