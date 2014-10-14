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

       [Required(ErrorMessage = "LocationID is required")]
        public int LocationID { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name length must be between 1 and 50")]
         public string Name { get; set; }
         [Required(ErrorMessage = "Street is required")]
         [StringLength(50, MinimumLength = 1, ErrorMessage = "Street length must be between 1 and 50")]
         public string Street { get; set; }
        [Required(ErrorMessage = "City is required")]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "City length must be between 1 and 30")]
         public string City { get; set; }
        [Required(ErrorMessage = "Province is required")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Province length must be  2")]
        public string Province { get; set; }
        [Required(ErrorMessage = "Phonenumber is required")]
        // [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        //[RegularExpression(@"[1-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9][0-9]",
        // ErrorMessage = "Personal phone format is not valid.")]
        public string Phone { get; set; }
        
        public bool Active { get; set; }


        public virtual ICollection<EmployeeLocation> EmployeeLocation { get; set; }
        public virtual ICollection<Shift> Shift { get; set; }
    }
}

