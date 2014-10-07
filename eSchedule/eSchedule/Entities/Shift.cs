using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
   public class Shift
   {
        [Required(ErrorMessage = "ShiftID is required")]
       public int ShiftID { get; set; }
        [Required(ErrorMessage = "StartTime is required")]
       public TimeSpan StartTime { get; set; }
       public TimeSpan? EndTime { get; set; }
       public System.DayOfWeek? DayOfWeek { get; set; }
       public int? MinEmployees { get; set; }
       public int? MaxEmployees { get; set; }
     [Required(ErrorMessage = "LocationID is required")]
       public int LocationID { get; set; }

       public virtual ICollection<Schedule> Schedule { get; set; }
       public virtual Location Location { get; set; }

   }
}

