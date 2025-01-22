using AutoMapper;
using Final.BL.DTOs.IdentityDTOs;
using Microsoft.AspNetCore.Identity;

namespace Final.BL.Profiles
{
    public class IdentityUserProfile:Profile
    {
        public IdentityUserProfile()
        {
            CreateMap<IdentityUser, IdentityLoginDTO>().ReverseMap();
            CreateMap<IdentityUser, IdentityRegisterDTO>().ReverseMap();
           
        }
    }
}
