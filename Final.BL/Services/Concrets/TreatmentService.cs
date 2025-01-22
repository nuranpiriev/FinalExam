using AutoMapper;
using Final.BL.DTOs.TreatmentDTOs;
using Final.BL.Services.Abstracts;
using Final.CL.Models.Entities;
using Final.DL.Repositories.Abstracts;


namespace Final.BL.Services.Concrets
{
    public class TreatmentService : ITreatmentService
    {
        readonly IRepository<Treatment> _repo;
        readonly IMapper _mapper;
       
        public async Task CreateTreatmentAsync(PostTreatmentDTO dto)
        {
            Treatment treatment = _mapper.Map<Treatment>(dto);
            await _repo.UpdateAsync(treatment);
        }

        public async Task DeleteTreatmentAsync(int id)
        {
            var treatment =await _repo.GetById(id);
            await _repo.DeleteAsync(treatment);
        }

        public async Task<ICollection<GetTreatmentDTO>> GetAllTreatmentAsync()
        {
            ICollection<Treatment> treatments =await _repo.GetAll("Treatment");
            return _mapper.Map<ICollection<GetTreatmentDTO>>(treatments);
        }

        public async Task<GetTreatmentDTO> GetTreatmentByIdAsync(int id)
        {
            Treatment treatment=await _repo.GetById(id);
            return  _mapper.Map<GetTreatmentDTO>(treatment);
        }

        public async Task UpdateTreatmentAsync(int id, PutTreatmentDTO dto)
        {
            Treatment treatment = _mapper.Map<Treatment>(dto);
            Treatment UpdateTreatment = await _repo.GetById(id);
            await _repo.UpdateAsync(UpdateTreatment);
        }
    }
}
