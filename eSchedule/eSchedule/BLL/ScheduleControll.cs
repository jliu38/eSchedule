using eSchedule.DAL;
using eSchedule.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.BLL
{
    [DataObject]
    public class ScheduleControll
    {

         #region Manage Locations
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddLocation(Location item)
        {    
            using (ScheduleContext context = new ScheduleContext())
            {
                //todo:Validation of waiter data....
                var added = context.Locations.Add(item);
                context.SaveChanges();              

            }
            //throw new NotImplementedException();
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateLocation(Location item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                //TODO :Validation
                var attached = context.Locations.Attach(item);
                var matchingWithExistingValues = context.Entry<Location>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }
        //[DataObjectMethod(DataObjectMethodType.Delete, false)]
        //public void DeleteLocation(Location item)
        //{
        //   using (ScheduleContext context = new ScheduleContext())
        //    {
        //        var existing = context.Locations.Find(item. LocationID);
        //        context.Locations.Remove(existing);
        //        context.SaveChanges();
        //    }
        //}
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Location> ListAllLocationss()
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                return context.Locations.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Location GetLocation(int LocationId)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                return context.Locations.Find(LocationId);
            }
        }
        #endregion
        #endregion

        //#region Ad-hoc
        //[DataObjectMethod(DataObjectMethodType.Select, false)]
        //public List<Reservation> LookupReservationsBySpecialEvent(string eventCode)
        //{
        //    using (RestaurantContext context = new RestaurantContext())
        //    {
        //        var data = from info in context.Reservations
        //                   where info.EventCode == eventCode
        //                   select info;
        //        return data.ToList();
        //    }
        //}
        //#endregion
    }
}


