using Randevu.Entities;
using Randevu.Entities.FluentMapping;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Randevu.DAL
{
    public class AppointmentContext : DbContext
    {

        public AppointmentContext()
        {
            Database.SetInitializer<AppointmentContext>(null);
        }
        public DbSet<Hour> Hours { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Polyclinic> Polyclinics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<HospitalDepartment> HospitalDepartments { get; set; }
        public DbSet<PolyclinicDepartment> PolyclinicDepartments { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Department>().HasMany(d => d.Polyclinics).WithMany(p => p.Departments).Map(x =>
            //    {
            //        x.MapLeftKey("DepartmentId");
            //        x.MapRightKey("PolyclinicId");
            //        x.ToTable("PolyclinicDepartment");
            //    }
            //);
            //modelBuilder.Entity<Department>().HasMany(d => d.Hospitals).WithMany(h => h.Departments).Map(x =>
            //{
            //    x.MapLeftKey("DepartmentId");
            //    x.MapRightKey("HospitalId");
            //    x.ToTable("HospitalDepartment");
            //}
            //);
            modelBuilder.Entity<Appointment>().HasRequired(d => d.Doctor).WithRequiredDependent().WillCascadeOnDelete(false);
            modelBuilder.Entity<Appointment>().HasOptional(p => p.Patient).WithOptionalDependent().WillCascadeOnDelete(false);

            modelBuilder.Configurations.Add(new MapHour());
            modelBuilder.Configurations.Add(new MapHospital());
            modelBuilder.Configurations.Add(new MapPolyclinic());
            modelBuilder.Configurations.Add(new MapDepartment());
            modelBuilder.Configurations.Add(new MapDiagnosis());
            modelBuilder.Configurations.Add(new MapUser());
            modelBuilder.Configurations.Add(new MapAppointment());
            modelBuilder.Configurations.Add(new MapExamination());
            modelBuilder.Configurations.Add(new MapPrescription());


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
