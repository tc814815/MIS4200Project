using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200Project.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object


namespace MIS4200Project.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<orderDetail> OrderDetails { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public System.Data.Entity.DbSet<MIS4200Project.Models.Appointment> Appointments { get; set; }
    }
}