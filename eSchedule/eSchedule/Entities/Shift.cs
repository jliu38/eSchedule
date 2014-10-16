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
        [Required(ErrorMessage = "PlacementContractID is required")]
        public int PlacementContractID { get; set; }
        [Required(ErrorMessage = "DayOfWeek is required")]
        public int DayOfWeek { get; set; }
        [Required(ErrorMessage = "StartTime is required")]
        [Range(7, 8, ErrorMessage = "StartTime must be between 7 and 8")]
       public TimeSpan StartTime { get; set; }
        [Required(ErrorMessage = "EndTime is required")]
        [Range(7, 8, ErrorMessage = "EndTime must be between 7 and 8")]
       public TimeSpan EndTime { get; set; }
        public byte NumberOfEmployees { get; set; }
        public bool Active { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<Schedule> Schedule { get; set; }
       public virtual PlacementContract PlacementContract { get; set; }

   }
}

