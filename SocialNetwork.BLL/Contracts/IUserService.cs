using SocialNetwork.BLL.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Contracts
{
    public interface IUserService
    {
        public Task<UserDTO> GetUserAsync(int id);
        public Task UpdateUserAsync(UserDTO userDTO);

    }
}
