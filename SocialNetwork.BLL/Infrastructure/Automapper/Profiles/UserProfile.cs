using AutoMapper;
using SocialNetwork.BLL.DTO_s;
using SocialNetwork.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Infrastructure.Automapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDTO, User>()
                .ReverseMap();
        }
    }
}
