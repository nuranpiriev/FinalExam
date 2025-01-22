using Final.BL.DTOs.DoctorDTOs;
using Final.BL.DTOs.TreatmentDTOs;

namespace Final.PL.ViewModels
{
    public class HomeVM
    {
        public ICollection<GetDoctorDTO> doctors;
        public ICollection<GetTreatmentDTO> treats;
    }
}
