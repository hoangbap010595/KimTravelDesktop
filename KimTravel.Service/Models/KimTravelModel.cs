namespace KimTravel.Service.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KimTravelModel : DbContext
    {
        public KimTravelModel()
            : base("name=sqlDataConnection") //Server
            //: base("name=LocalConnection")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<CarType> CarTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DetailPrintTour> DetailPrintTours { get; set; }
        public virtual DbSet<GroupPartner> GroupPartners { get; set; }
        public virtual DbSet<GroupTour> GroupTours { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<PrintTour> PrintTours { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupTour>()
                .HasMany(e => e.Tours)
                .WithOptional(e => e.GroupTour)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PrintTour>()
                .HasMany(e => e.DetailPrintTours)
                .WithOptional(e => e.PrintTour)
                .HasForeignKey(e => e.PrintID)
                .WillCascadeOnDelete();
        }
    }
}
