using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
   public class EmployeeLocation
   {
       [Key, Column(Order = 1)]
       [Required(ErrorMessage = "EmployeeID is required")]
       public int EmployeeID { get; set; }
       [Key]
       [Column(Order = 2)]
       [Required(ErrorMessage = "LocationID is required")]
       public int LocationID { get; set; }


       //Navigation Properties Should be declared as virtual
       public virtual Employee Employee { get; set; }
       public virtual Location Location { get; set; }
       // prop
       //then, [Tab][Tab]

   }
}

