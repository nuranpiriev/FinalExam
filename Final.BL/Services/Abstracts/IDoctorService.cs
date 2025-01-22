using Final.BL.DTOs.DoctorDTOs;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.BL.Services.Abstracts
{
    public interface IDoctorService
    {
        Task<GetDoctorDTO> GetDoctorByIdAsync(int id);
        Task CreateDoctorAsync(PostDoctorDTO dto);
        Task DeleteDoctorAsync(int id);
        Task UpdateDoctorAsync(int id,PutDoctorDTO dto);
        Task<ICollection<GetDoctorDTO>> GetAllDoctorAsync();
    }
}
