using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eSchedule.Entities.POCOs
{
    public class EmployeeSkillDirectory
    {
        public string SkillDescription { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Level { get; set; }

        public int? YOE { get; set; }
    }
}
