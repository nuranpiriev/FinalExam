using Final.CL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.CL.Models.Entities
{
    public class Doctor:BaseAuditable
    {
        public Treatment Treatment { get; set; }
        public int TreatmentId {  get; set; }
        public string ImageURL {  get; set; }

        public string Name {  get; set; }
    }
}
