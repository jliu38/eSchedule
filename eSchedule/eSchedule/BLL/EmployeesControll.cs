using eSchedule.DAL;
using eSchedule.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.BLL
{
    [DataObject]
    public class EmployeesControll
    {
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public List<EmployeeSkillDirectory> GetEmployeeSkill()
        {
            using (var context = new ScheduleContext())
            {
                var results = from cat in context.EmployeeSkills
                              orderby cat.Skill.Description
                              select new EmployeeSkillDirectory()
                                  {
                                      SkillDescription = cat.Skill.Description,
                                      Name = cat.Employee.FirstName + " " + cat.Employee.LastName,
                                      Phone = cat.Employee.HomePhone,
                                      Level = cat.Level.ToString(),
                                      YOE = cat.YearsOfExperience
                                  };

                return results.ToList();
            }
        }
    }
}