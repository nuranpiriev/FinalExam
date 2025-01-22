using AutoMapper;
using Final.BL.DTOs.DoctorDTOs;
using Final.CL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.BL.Profiles
{
    public class DoctorProfile:Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, GetDoctorDTO>().ReverseMap();
            CreateMap<Doctor, PutDoctorDTO>().ReverseMap();
            CreateMap<Doctor, PostDoctorDTO>().ReverseMap();
        }
    }
}
