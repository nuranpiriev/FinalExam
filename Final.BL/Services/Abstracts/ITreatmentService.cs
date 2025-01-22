using Final.BL.DTOs.TreatmentDTOs;

namespace Final.BL.Services.Abstracts
{
    public interface ITreatmentService
    {
        Task<GetTreatmentDTO> GetTreatmentByIdAsync(int id);
        Task CreateTreatmentAsync(PostTreatmentDTO dto);
        Task DeleteTreatmentAsync(int id);
        Task UpdateTreatmentAsync(int id,PutTreatmentDTO dto);
        Task<ICollection<GetTreatmentDTO>> GetAllTreatmentAsync();
    }
}
