using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
   public class Shift
   {
       public int ShiftID { get; set; }
       public DateTime StartTime { get; set; }
       public DateTime? EndTime { get; set; }
       public int? DayOfWeek { get; set; }
       public int? MinEmployees { get; set; }
       public int? MaxEmployees { get; set; }
       public int LocationID { get; set; }

       public virtual ICollection<Schedule> Schedule { get; set; }
       public virtual Location Location { get; set; }

   }
}

