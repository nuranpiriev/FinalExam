using Microsoft.AspNetCore.Http;

namespace Final.BL.DTOs.DoctorDTOs
{
    public class PostDoctorDTO
    {
        public string Name { get; set; }
        public int TreatmentId {  get; set; }
        public IFormFile? Image { get;set; }
        
    }
}
