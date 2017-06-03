namespace Infinity.Visibilty.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VisibilityDbContext : DbContext
    {
        public VisibilityDbContext()
            : base("name=VisibilityDbCon")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<driver_schedule> driver_schedule { get; set; }
        public virtual DbSet<driver_tractor> driver_tractor { get; set; }
        public virtual DbSet<driver_trip> driver_trip { get; set; }
        public virtual DbSet<position> position { get; set; }
        public virtual DbSet<store_trailer> store_trailer { get; set; }
        public virtual DbSet<trailer> trailer { get; set; }
        public virtual DbSet<trip_eta_tracking> trip_eta_tracking { get; set; }
        public virtual DbSet<trip_movement> trip_movement { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<driver_schedule>()
                .Property(e => e.business_hours_type)
                .IsUnicode(false);

            modelBuilder.Entity<position>()
                .Property(e => e.latitude)
                .HasPrecision(18, 6);

            modelBuilder.Entity<position>()
                .Property(e => e.logitutde)
                .HasPrecision(18, 6);

            modelBuilder.Entity<trailer>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<trailer>()
                .Property(e => e.trailer_type_code)
                .IsUnicode(false);

            modelBuilder.Entity<trip_movement>()
                .Property(e => e.org_loc_type)
                .IsUnicode(false);

            modelBuilder.Entity<trip_movement>()
                .Property(e => e.dest_loc_type)
                .IsUnicode(false);

            modelBuilder.Entity<trip_movement>()
                .Property(e => e.org_loc_lat)
                .HasPrecision(18, 6);

            modelBuilder.Entity<trip_movement>()
                .Property(e => e.org_loc_log)
                .HasPrecision(18, 6);

            modelBuilder.Entity<trip_movement>()
                .Property(e => e.dest_loc_lat)
                .HasPrecision(18, 6);

            modelBuilder.Entity<trip_movement>()
                .Property(e => e.dest_loc_log)
                .HasPrecision(18, 6);
        }
    }
}
