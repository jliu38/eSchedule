﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.Entities
{
   public class Location
    {
        public Location()
        {
            Active = true;
        }


        public int LocationID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }


        public virtual ICollection<EmployeeLocation> EmployeeLocation { get; set; }
        public virtual ICollection<Shift> Shift { get; set; }
    }
}

