using eSchedule.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSchedule.DAL
{
    public class ScheduleContext : DbContext
    {
        //Contructor that calls a base-class contructor to specify the
        //conection string we need to use
        public ScheduleContext() : base("name=WorkSchedule") { }
        #region Table to Entity mappings
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<PlacementContract> PlacementContracts { get; set; }
        public DbSet<Skill> Skills { get; set; }

        #endregion

        /* #region Over-ride OnModelCreating
        //
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reservation>().HasMany(r => r.Tables)
                .WithMany(t => t.Reservation)
                .Map(mapping =>
                    {
                        mapping.ToTable("ReservationTables");
                        mapping.MapLeftKey("ReservationID");
                        mapping.MapRightKey("TableID");


                    });
            base.OnModelCreating(modelBuilder);
        }

        #endregion */
    }
}
