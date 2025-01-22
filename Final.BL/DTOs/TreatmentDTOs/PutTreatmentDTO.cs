using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.BL.DTOs.TreatmentDTOs
{
    public class PutTreatmentDTO
    {
        public int Id {  get; set; }
        public string Title {  get; set; }
        public string Description {get; set; }
        public IFormFile? Image { get; set; }

    }
}
