using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
    public class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }
        
        [Column(Order = 1)]
        public int EmployeeID { get; set; }
        public int LocationID { get; set; }
      [Column(Order = 2)]
        public int ShiftID { get; set; }
        
        public DateTime Day { get; set; }

        public virtual Shift Shift { get; set; }
        public  virtual EmployeeLocation EmployeeLocation {get; set; }
    }

}