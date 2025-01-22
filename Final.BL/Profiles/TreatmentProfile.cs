using AutoMapper;
using Final.BL.DTOs.TreatmentDTOs;
using Final.CL.Models.Entities;

namespace Final.BL.Profiles
{
    public class TreatmentProfile:Profile
    {
        public TreatmentProfile()
        {
            CreateMap<Treatment, GetTreatmentDTO>().ReverseMap();
            CreateMap<Treatment, PutTreatmentDTO>().ReverseMap();
            CreateMap<Treatment, PostTreatmentDTO>().ReverseMap();
        }
    } 
}
