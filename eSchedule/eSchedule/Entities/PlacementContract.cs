using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
     public class PlacementContract
    {
        [Required(ErrorMessage = "PlacementContractID is required")]
         public int PlacementContractID { get; set; }
        [Required(ErrorMessage = "StartDate is required")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "EndDate is required")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "StartTime is required")]
        [Range(7, 8, ErrorMessage = "StartTime must be between 7 and 8")]
        public int LocationID { get; set; }
        [Required(ErrorMessage = "EndTime is required")]
        [Range(7, 8, ErrorMessage = "EndTime must be between 7 and 8")]
        public TimeSpan EndTime { get; set; }


        public virtual ICollection<Shift> Shift { get; set; }
        public virtual Location Location { get; set; }
    }
}
