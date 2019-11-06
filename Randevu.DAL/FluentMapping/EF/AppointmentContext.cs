using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Randevu.Entities.FluentMapping;

namespace Randevu.Entities.EF
{
    public class AppointmentContext:DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Hour> Hours { get; set; }
        public DbSet<PolyclinicDepartment> PolyclinicDepartments { get; set; }
        public DbSet<Polyclinic> Polyclinics { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<User> Users { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Configurations.Add(new MapAppointment());
            modelBuilder.Configurations.Add(new MapCity());
            modelBuilder.Configurations.Add(new MapDepartment());
            modelBuilder.Configurations.Add(new MapDiagnosis());
            modelBuilder.Configurations.Add(new MapDistrict());
            modelBuilder.Configurations.Add(new MapExamination());
            modelBuilder.Configurations.Add(new MapHospital());
            modelBuilder.Configurations.Add(new MapHour());
            modelBuilder.Configurations.Add(new MapPolyclinic());
            modelBuilder.Configurations.Add(new MapPolyclinicDepartment());
            modelBuilder.Configurations.Add(new MapPrescription());
            modelBuilder.Configurations.Add(new MapUser());


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {

            foreach (var register in ChangeTracker.Entries().Where(x => x.Entity.GetType().GetProperty("CreatedDate") != null))
            {
                if (register.State == EntityState.Added)
                {
                    register.Property("UpdatedDate").IsModified = false;
                    register.Property("CreatedDate").CurrentValue = DateTime.Now;
                }

                if (register.State == EntityState.Modified)
                {
                    register.Property("UpdatedDate").CurrentValue = DateTime.Now;
                    register.Property("CreatedDate").IsModified = false;
                }

            }
            return base.SaveChanges();
        }


    }
}
