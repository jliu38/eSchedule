using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
     public class Skill
    {

         public int SkillID { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Description length must be between 1 and 100")]
       public string Description { get; set; }


        public bool RequiresTicket { get; set; }


        public virtual ICollection<EmployeeSkill> EmployeeSkill { get; set; }
   }
}


