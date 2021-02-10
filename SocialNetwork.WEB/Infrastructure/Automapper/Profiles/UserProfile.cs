using AutoMapper;
using SocialNetwork.BLL.DTO_s;
using SocialNetwork.DAL.Entities;
using SocialNetwork.WEB.ViewModels;


namespace SocialNetwork.WEB.Infrastructure.Automapper.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserLoginViewModel, UserLoginDTO>();
            CreateMap<UserRegisterViewModel, UserDTO>();
        }
    }
}
