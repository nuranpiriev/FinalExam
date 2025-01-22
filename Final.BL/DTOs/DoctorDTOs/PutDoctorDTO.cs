using Microsoft.AspNetCore.Http;

namespace Final.BL.DTOs.DoctorDTOs
{
    public class PutDoctorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TreatmentId {get; set; }
        public IFormFile? Image { get; set; }
    }
}
