using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Final.BL.DTOs.DoctorDTOs
{
    public class GetDoctorDTO
    {
        public int Id { get; set; } 
        public string Name {  get; set; }
        public string ImageURL {  get; set; }
        public string TreatmentTitle {  get; set; }


    } 
}
