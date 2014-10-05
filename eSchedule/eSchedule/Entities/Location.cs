using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
   public class Location
    {
        public Location()
        {
            Active = true;
        }


        public int LocationID { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
       // [Required(ErrorMessage = "Name is required")]
        //[Range(1, 50, ErrorMessage = "Name length must be between 1 and 50")]
        [Required, StringLength(50)]
        public string Street { get; set; }
       // [Required(ErrorMessage = "Street is required")]
       // [Range(1, 50, ErrorMessage = "Street length must be between 1 and 50")]
        [Required, StringLength(30)]
        public string City { get; set; }
        //[Required(ErrorMessage = "City is required")]
        //[Range(1, 30, ErrorMessage = "City length must be between 1 and 30")]
        [Required, StringLength(2)]
        public string Province { get; set; }
        //[Required(ErrorMessage = "Province is required")]
       // [Range(0, 2, ErrorMessage = "Province length must be  2")]
        [Required, StringLength(12)]
        public string Phone { get; set; }
        //[Required(ErrorMessage = "Phone is required")]
        //[Range(1, 12, ErrorMessage = "Phone length must be between 1 12")]
        public bool Active { get; set; }


        public virtual ICollection<EmployeeLocation> EmployeeLocation { get; set; }
        public virtual ICollection<Shift> Shift { get; set; }
    }
}

