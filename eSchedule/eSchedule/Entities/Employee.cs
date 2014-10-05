using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
   public class Employee
   {
       public Employee()
       {
           Active = true;
       }


       public int EmployeeID { get; set; }
       [Required, StringLength(50)]
       public string FirstName { get; set; }
      // [Required(ErrorMessage = "FirstName is required")]
      // [Range(1, 50, ErrorMessage = "FirstName length must be between 1 and 50")]
        [Required, StringLength(50)]
       public string LastName { get; set; }
       //[Required(ErrorMessage = "LastName is required")]
      // [Range(1, 50, ErrorMessage = "LastName length must be between 1 and 50")]
        [Required, StringLength(12)]
       public string HomePhone { get; set; }
       //[Required(ErrorMessage = "HomePhone is required")]
      // [Range(1, 12, ErrorMessage = "HomePhone length must be between 1 and 12")]
       public bool Active { get; set; }


       public virtual ICollection<EmployeeLocation> EmployeeLocation { get; set; }
   }
}

