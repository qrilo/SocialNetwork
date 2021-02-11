using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.BLL.Contracts;
using SocialNetwork.BLL.DTO_s;
using SocialNetwork.DAL.EFCoreContext;
using SocialNetwork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        public UserService(DatabaseContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserDTO> GetUserAsync(int id)
        {
            var user = await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Id == id);

            var dto = _mapper.Map<User, UserDTO>(user);

            return dto;
        }
    }
}
