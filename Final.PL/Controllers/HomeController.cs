using Final.BL.DTOs.DoctorDTOs;
using Final.BL.Services.Abstracts;
using Final.PL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Final.PL.Controllers
{
    public class HomeController : Controller
    {
        readonly IDoctorService _doctorService;
        readonly ITreatmentService _treatmentService;
        public async Task<IActionResult> Index()
        {
            var doctor = await _doctorService.GetAllDoctorAsync();
            var treatment = await _treatmentService.GetAllTreatmentAsync();

            HomeVM vm = new HomeVM()
            {
                doctors=doctor,
                treats=treatment

            };
            return View(vm);
        }
    }
}
