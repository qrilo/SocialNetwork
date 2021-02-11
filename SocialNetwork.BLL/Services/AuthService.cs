using AutoMapper;
using SocialNetwork.BLL.Contracts;
using SocialNetwork.BLL.DTO_s;
using SocialNetwork.DAL.EFCoreContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.DAL.Entities;
using SocialNetwork.BLL.ServiceResult;

namespace SocialNetwork.BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public AuthService(DatabaseContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> GetIsUserExistsAsync(string email)
        {
            var result = await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Email == email);

            return result != null;
        }

        public async Task<LoginResult> TryLoginUserAsync(UserLoginDTO userLoginDTO)
        {
            var user = await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Email == userLoginDTO.Email);

            if (user != null && BCrypt.Net.BCrypt.Verify(userLoginDTO.Password, user.Password))
            {
                return new LoginResult
                {
                    Logged = true,
                    UserDTO = _mapper.Map<User, UserDTO>(user)
                };
            }
            else
            {
                return new LoginResult
                {
                    Logged = false,
                };
            }                
        }

        public async Task<UserDTO> TryRegisterUserAsync(UserDTO userDTO)
        {
            var user = _mapper.Map<UserDTO, User>(userDTO);
//            user.Role = Shared.Role.User;
            user.Password = BCrypt.Net.BCrypt.HashPassword(userDTO.Password);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return _mapper.Map<User, UserDTO>(user);
        }
    }
}
