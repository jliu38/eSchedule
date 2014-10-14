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
        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(50,MinimumLength=1, ErrorMessage = "FirstName length must be between 1 and 50")]
         public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "LastName length must be between 1 and 50")]
          public string LastName { get; set; }
        //[Required(ErrorMessage = "HomePhone is required")]
        // [StringLength(12, MinimumLength = 12, ErrorMessage = "HomePhone length must be 12")]
        [Required(ErrorMessage = "Phonenumber is required")]
      // [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        //[RegularExpression(@"[1-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9][0-9]",
        // ErrorMessage = "Personal phone format is not valid.")]
       public string HomePhone { get; set; }
       
       public bool Active { get; set; }


       public virtual ICollection<EmployeeLocation> EmployeeLocation { get; set; }
   }
}

