using Final.CL.Models.Base;

namespace Final.CL.Models.Entities
{
    public class Treatment:BaseEntity 
    {
     
 
        public string ImageURL { get; set; }
        public string Title {  get; set; }
        public string Description { get; set; }
        public ICollection<Doctor> Doctors { get; set; }

    }
}
