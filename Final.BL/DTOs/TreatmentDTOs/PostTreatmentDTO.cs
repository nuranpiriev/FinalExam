using Microsoft.AspNetCore.Http;

namespace Final.BL.DTOs.TreatmentDTOs
{
    public class PostTreatmentDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }

    }
}
