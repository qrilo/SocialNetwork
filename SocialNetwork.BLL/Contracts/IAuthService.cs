using SocialNetwork.BLL.DTO_s;
using SocialNetwork.BLL.ServiceResult;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Contracts
{
    public interface IAuthService
    {
        public Task <bool> GetIsUserExistsAsync(string email);
        public Task TryRegisterUserAsync(UserDTO userDTO);
        public Task<LoginResult> TryLoginUserAsync(UserLoginDTO userLoginDTO);
    }
}
