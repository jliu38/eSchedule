using eSchedule.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.BLL
{
    [DataObject]
   public class ScheduleAdminController
    {
        #region Manage Waiters
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert,false)]
        public int AddWaiter(Waiter item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                    //todo:Validation of waiter data....
                var added = context.Waiters.Add(item);
                context.SaveChanges();
                return added.WaiterID;

            }
            //throw new NotImplementedException();
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateWaiter(Waiter item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                //TODO :Validation
                var attached = context.Waiters.Attach(item);
                var matchingWithExistingValues = context.Entry<Waiter>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteWaiter(Waiter item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                var existing = context.Waiters.Find(item.WaiterID);
                context.Waiters.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Waiter> ListAllWaiter()
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                return context.Waiters.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Waiter GetWaiter(int waiterId)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                return context.Waiters.Find(waiterId);
            }
        }
        #endregion
        #endregion

        #region Manage Tables
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddTable(Table item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                //todo:Validation of waiter data....
                var added = context.Tables.Add(item);
                context.SaveChanges();
                return added.TableID;

            }
            //throw new NotImplementedException();
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateTable(Table item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                //TODO :Validation
                var attached = context.Tables.Attach(item);
                var matchingWithExistingValues = context.Entry<Table>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteTable(Table item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                var existing = context.Tables.Find(item.TableID);
                context.Tables.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Table> ListAllTable()
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                return context.Tables.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Table GetTable(int TableId)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                return context.Tables.Find(TableId);
            }
        }
        #endregion
        #endregion

        #region Manage Items
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddItem(Item item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                //todo:Validation of waiter data....
                var added = context.Items.Add(item);
                context.SaveChanges();
                return added.ItemID;

            }
            //throw new NotImplementedException();
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateWaiter(Item item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                //TODO :Validation
                var attached = context.Items.Attach(item);
                var matchingWithExistingValues = context.Entry<Item>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteWaiter(Item item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                var existing = context.Items.Find(item.ItemID);
                context.Items.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Item> ListAllItem()
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                return context.Items.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Item GetItem(int ItemId)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                return context.Items.Find(ItemId);
            }
        }
        #endregion
        #endregion

        #region Manage Special Events
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddSpecialEvent(SpecialEvent item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                //todo:Validation of waiter data....
                var added = context.SpecialEvents.Add(item);
                context.SaveChanges();              

            }
            //throw new NotImplementedException();
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateSpecialEvent(SpecialEvent item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                //TODO :Validation
                var attached = context.SpecialEvents.Attach(item);
                var matchingWithExistingValues = context.Entry<SpecialEvent>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteSpecialEvent(SpecialEvent item)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                var existing = context.SpecialEvents.Find(item.EventCode);
                context.SpecialEvents.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> ListAllSpecialEvents()
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                return context.SpecialEvents.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SpecialEvent GetSpecialEvent(int SpecialEventId)
        {
            using (ScheduleContext context = new ScheduleContext())
            {
                return context.SpecialEvents.Find(SpecialEventId);
            }
        }
        #endregion
        #endregion

    }
}

