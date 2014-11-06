using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
   public class EmployeeSkill
    {
       public enum SkillLevel
       {
           Novice,
           Proficent,
           Expert
       }
       [Key]
       public int EmployeeSkillID { get; set; }
       [Required(ErrorMessage = "EmployeeID is required.")]
       public int EmployeeID { get; set; }
       [Required(ErrorMessage = "SkillID is required.")]
       public int SkillID { get; set; }
       [Required(ErrorMessage = "Level is required.")]
       public SkillLevel Level { get; set; }
       public int? YearsOfExperience { get; set; }

       //navigation
       public virtual Skill Skill { get; set; }
       public virtual Employee Employee { get; set; }
    }
}




       // [Key]
       // [Required(ErrorMessage = "EmployeeSkillID is required")]
       //public int EmployeeSkillID { get; set; }

       // [Column(Order = 1)]
       // [Required(ErrorMessage = "EmployeeID is required")]
       // public int EmployeeID { get; set; }
        
       // [Column(Order = 2)]
       // [Required(ErrorMessage = "SkillID is required")]
       // public int SkillID { get; set; }

       // [Required(ErrorMessage = "Level is required")]
       // public int Level { get; set; }

        
       // public int YearsOfExperience { get; set; }

       // public virtual Skill Skill { get; set; }
       // public virtual Employee Employee { get; set; }
   