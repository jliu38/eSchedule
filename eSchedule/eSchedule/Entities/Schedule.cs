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
        [Required(ErrorMessage = "ScheduleID is required")]
        public int ScheduleID { get; set; }
        public DateTime Day { get; set; }
        [Column(Order = 1)]
        [Required(ErrorMessage = "ScheduleID is required")]
        public int EmployeeID { get; set; }
        [Column(Order = 2)]
      [Required(ErrorMessage = "ShiftID is required")]
        public int ShiftID { get; set; }
        
        

        public virtual Shift Shift { get; set; }
        public  virtual Employee Employee {get; set; }
    }

}