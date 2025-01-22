using AutoMapper;
using Final.BL.DTOs.DoctorDTOs;
using Final.BL.Services.Abstracts;
using Final.CL.Models.Entities;
using Final.DL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final.BL.Services.Concrets
{
    public class DoctorService : IDoctorService
    {
        readonly IRepository<Doctor> _repo;
        readonly IMapper _mapper;
       
        public async Task CreateDoctorAsync(PostDoctorDTO dto)
        {
            Doctor doctor = _mapper.Map<Doctor>(dto);
            doctor.CreatedAt= DateTime.Now;
            await _repo.UpdateAsync(doctor);
        }

        public async Task DeleteDoctorAsync(int id)
        {
            var doctor =await _repo.GetById(id);
            await _repo.DeleteAsync(doctor);
        }

        public async Task<ICollection<GetDoctorDTO>> GetAllDoctorAsync()
        {
            ICollection<Doctor> doctors =await _repo.GetAll("Treatment");
            return _mapper.Map<ICollection<GetDoctorDTO>>(doctors);
        }

        public async Task<GetDoctorDTO> GetDoctorByIdAsync(int id)
        {
            Doctor doctor=await _repo.GetById(id);
            return  _mapper.Map<GetDoctorDTO>(doctor);
        }

        public async Task UpdateDoctorAsync(int id, PutDoctorDTO dto)
        {
            Doctor doctor = _mapper.Map<Doctor>(dto);
            Doctor UpdateDoctor = await _repo.GetById(id);
            UpdateDoctor.CreatedAt = doctor.CreatedAt;
            UpdateDoctor.UpdatedAt = DateTime.Now;
            await _repo.UpdateAsync(UpdateDoctor);
        }
    } 
}
