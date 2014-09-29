using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
   public class Employee
   {
       public Employee()
       {
           Active = true;
       }


       public int EmployeeID { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string HomePhone { get; set; }
       public bool Active { get; set; }


       public virtual ICollection<EmployeeLocation> EmployeeLocation { get; set; }
   }
}

