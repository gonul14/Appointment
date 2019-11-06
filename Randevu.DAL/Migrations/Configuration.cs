namespace Randevu.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Randevu.DAL.AppointmentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Randevu.DAL.AppointmentContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //context.Hospitals.Add(new Entities.Hospital { HospitalName = "BAKIRKÖY- DR. SADİ KONUK EĞİTİM ARAŞTIRMA HASTANESİ" });
            //context.Hospitals.Add(new Entities.Hospital { HospitalName = "BAKIRKÖY PROF. DR. MAZHAR OSMAN RUH SAĞLIĞI VE SİNİR HASTALIKLARI HASTANESİ" });

            //context.Hospitals.Add(new Entities.Hospital { HospitalName = "MEHMET AKİCERRAHİSİ EĞİTİM VE ARAŞTIRMA HASTANESİ" });
            //context.Hospitals.Add(new Entities.Hospital { HospitalName = "KÜÇÜKÇEKMECE- KANUNİ SULTAN SÜLEYMAN EĞİTİM VE ARAŞTIRMA HASTANESİ" });

            //context.Hospitals.Add(new Entities.Hospital { HospitalName = "ANKARA 29 MAYIS DEVLET HASTANESİ" });

            //context.Hospitals.Add(new Entities.Hospital { HospitalName = "ANKARA KEÇİÖREN EĞİTİM VE ARAŞTIRMA HASTANESİ" });
            //context.Hospitals.Add(new Entities.Hospital { HospitalName = "ANKARA ATATÜRK GÖĞÜS HASTALIKLARI VE GÖĞÜS CERRAHİSİ EĞİTİM VE ARAŞTIRMA HASTANESİ" });

            //context.Hospitals.Add(new Entities.Hospital { HospitalName = "BURSA İNEGÖL DEVLET HASTANESİ (İNEGÖL DEVLET HASTANESİ)" });
            //context.Hospitals.Add(new Entities.Hospital { HospitalName = "BURSA GEMLİK DEVLET HASTANESİ (GEMLİK DEVLET HASTANESİ)" });

            ////policlinic

            //context.Polyclinics.Add(new Entities.Polyclinic { HospitalId = 1, PolyclinicName = "İSTANBUL- BAKIRKÖY- DR. SADİ KONUK EĞİTİM ARAŞTIRMA " });
            //context.Polyclinics.Add(new Entities.Polyclinic { HospitalId = 3, PolyclinicName = "İSTANBUL- MEHMET AKİF ERSOY GÖĞÜS KALP VE DAMAR CERRAHİSİ" });
            //context.Polyclinics.Add(new Entities.Polyclinic { HospitalId = 5, PolyclinicName = "ANKARA 29 MAYIS DEVLET HASTANESİ MUSTAFA DURSUN" });
            //context.Polyclinics.Add(new Entities.Polyclinic { HospitalId = 5, PolyclinicName = "ANKARA 29 MAYIS DEVLET HASTANESİ VİLAYETLER HİZMET BİNASI" });
            //context.Polyclinics.Add(new Entities.Polyclinic { HospitalId = 5, PolyclinicName = "ANKARA 29 MAYIS DEVLET POLİKLİNİĞİ" });
            //context.Polyclinics.Add(new Entities.Polyclinic { HospitalId = 6, PolyclinicName = "ANKARA KEÇİÖREN SEMT POLİKLİNİĞİ" });
            //context.Polyclinics.Add(new Entities.Polyclinic { HospitalId = 6, PolyclinicName = "ANKARA KEÇİÖREN  SEMT POLİKLİNİĞİ" });

            //context.Hours.Add(new Entities.Hour { HourInfo = "09:00" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "09:30" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "10:00" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "10:30" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "11:00" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "11:30" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "12:00" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "13:30" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "14:00" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "14:30" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "15:00" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "15:30" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "16:00" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "16:30" });
            //context.Hours.Add(new Entities.Hour { HourInfo = "17:00" });

            //context.Departments.Add(new Entities.Department { DepartmentName = "Kulak Burun Boğaz" });
            //context.Departments.Add(new Entities.Department { DepartmentName = "Kalp Damar Cerrahisi" });
            //context.Departments.Add(new Entities.Department { DepartmentName = "Beyin ve Sinir Cerrahisi" });
            //context.Departments.Add(new Entities.Department { DepartmentName = "Çocuk Hastalıkları" });
            //context.Departments.Add(new Entities.Department { DepartmentName = "İç Hastalıkları" });

            //context.Diagnosis.Add(new Entities.Diagnosis { DepartmentId = 1, DiagnosisName = "Üst Solunum Yolu Enfeksiyonu" });
            //context.Diagnosis.Add(new Entities.Diagnosis { DepartmentId = 1, DiagnosisName = "İşitme Kaybı" });
            //context.Diagnosis.Add(new Entities.Diagnosis { DepartmentId = 2, DiagnosisName = "Damar Tıkanıklığı" });
            //context.Diagnosis.Add(new Entities.Diagnosis { DepartmentId = 2, DiagnosisName = "Kalp Ritminde Düzensizlik" });
            //context.Diagnosis.Add(new Entities.Diagnosis { DepartmentId = 3, DiagnosisName = "Migren" });
            //context.Diagnosis.Add(new Entities.Diagnosis { DepartmentId = 4, DiagnosisName = "Enfeksiyon" });
            //context.Diagnosis.Add(new Entities.Diagnosis { DepartmentId = 4, DiagnosisName = "Nefes Daralnası" });
            //context.Diagnosis.Add(new Entities.Diagnosis { DepartmentId = 5, DiagnosisName = "Karaciğer Yağlanması" });
            //context.Diagnosis.Add(new Entities.Diagnosis { DepartmentId = 5, DiagnosisName = "Böbrek Fonksiyonlarında Düzensizlik" });

            //context.Users.Add(new Entities.User { IdentityNo = "123", FirstName = "Leman", LastName = "Yılmaz", BirthDate = new DateTime(1992, 12, 12), Password = "1", Email = "leman@gmail.com", UserRole = Entities.User.UserType.Pharmacist, Gender = "Kadın", CreatedDate = DateTime.Now, IsValid = true });

            //context.Users.Add(new Entities.User { IdentityNo = "456", FirstName = "Mehmet", LastName = "Korkmaz", BirthDate = new DateTime(1990, 12, 12), Password = "2", Email = "m@gmail.com", UserRole = Entities.User.UserType.Doctor, Gender = "Erkek", DepartmentId = 1, CreatedDate = DateTime.Now, IsValid = true, HospitalId = 1 });

            //context.Users.Add(new Entities.User { IdentityNo = "789", FirstName = "Fatma", LastName = "Korkmaz", BirthDate = new DateTime(1990, 12, 12), Password = "3", Email = "a@gmail.com", UserRole = Entities.User.UserType.Doctor, Gender = "Kadın", DepartmentId = 2, CreatedDate = DateTime.Now, IsValid = true, HospitalId = 1 });

            //context.Users.Add(new Entities.User { IdentityNo = "963", FirstName = "Gül", LastName = "Korkmaz", BirthDate = new DateTime(1990, 12, 12), Password = "4", Email = "a@gmail.com", UserRole = Entities.User.UserType.Doctor, Gender = "Kadın", DepartmentId = 3, CreatedDate = DateTime.Now, IsValid = true, HospitalId = 1 });

            //context.Users.Add(new Entities.User { IdentityNo = "741", FirstName = "Ali", LastName = "Korkmaz", BirthDate = new DateTime(1990, 12, 12), Password = "23", Email = "ali@gmail.com", UserRole = Entities.User.UserType.Doctor, Gender = "Erkek", DepartmentId = 2, CreatedDate = DateTime.Now, IsValid = true, HospitalId = 2 });

            //context.Users.Add(new Entities.User { IdentityNo = "951", FirstName = "Fatma", LastName = "Gül", BirthDate = new DateTime(1990, 11, 12), Password = "61", Email = "fatma@gmail.com", UserRole = Entities.User.UserType.Patient, Gender = "K", CreatedDate = DateTime.Now, IsValid = true });

            //context.Users.Add(new Entities.User { IdentityNo = "357", FirstName = "Güzel", LastName = "Gül", BirthDate = new DateTime(1990, 11, 12), Password = "78", Email = "guzel@gmail.com", UserRole = Entities.User.UserType.Patient, Gender = "K", CreatedDate = DateTime.Now, IsValid = true });

            //context.Users.Add(new Entities.User { IdentityNo = "523", FirstName = "Hatice", LastName = "Gül", BirthDate = new DateTime(1990, 11, 12), Password = "98", Email = "hatice@gmail.com", UserRole = Entities.User.UserType.Patient, Gender = "K", CreatedDate = DateTime.Now, IsValid = true });


            //context.Appointments.Add(new Entities.Appointment { DoctorId = 2, HourId = 1, PatientId = 6, AppointmentDate = new DateTime(2019, 10, 29) });
            //context.Appointments.Add(new Entities.Appointment { DoctorId = 2, HourId = 2, PatientId = 7, AppointmentDate = new DateTime(2019, 10, 29) });
            //context.Appointments.Add(new Entities.Appointment { DoctorId = 2, HourId = 3, PatientId = 8, AppointmentDate = new DateTime(2019, 10, 30) });
            //context.Appointments.Add(new Entities.Appointment { DoctorId = 3, HourId = 4, PatientId = 6, AppointmentDate = new DateTime(2019, 10, 30) });
            //context.Appointments.Add(new Entities.Appointment { DoctorId = 3, HourId = 1, PatientId = 7, AppointmentDate = new DateTime(2019, 10, 30) });


            //context.PolyclinicDepartments.Add(new Entities.PolyclinicDepartment { DepartmentId = 1, PolyclinicId = 1 });
            //context.PolyclinicDepartments.Add(new Entities.PolyclinicDepartment { DepartmentId = 2, PolyclinicId = 1 });
            //context.PolyclinicDepartments.Add(new Entities.PolyclinicDepartment { DepartmentId = 3, PolyclinicId = 1 });
            //context.PolyclinicDepartments.Add(new Entities.PolyclinicDepartment { DepartmentId = 1, PolyclinicId = 2 });
            //context.PolyclinicDepartments.Add(new Entities.PolyclinicDepartment { DepartmentId = 2, PolyclinicId = 2 });
            //context.PolyclinicDepartments.Add(new Entities.PolyclinicDepartment { DepartmentId = 3, PolyclinicId = 2 });
            //context.PolyclinicDepartments.Add(new Entities.PolyclinicDepartment { DepartmentId = 3, PolyclinicId = 4 });
            //context.PolyclinicDepartments.Add(new Entities.PolyclinicDepartment { DepartmentId = 3, PolyclinicId = 3 });


            //context.HospitalDepartments.Add(new Entities.HospitalDepartment { HospitalId = 1, DepartmentId = 1 });
            //context.HospitalDepartments.Add(new Entities.HospitalDepartment { HospitalId = 1, DepartmentId = 2 });
            //context.HospitalDepartments.Add(new Entities.HospitalDepartment { HospitalId = 1, DepartmentId = 3 });
            //context.HospitalDepartments.Add(new Entities.HospitalDepartment { HospitalId = 2, DepartmentId = 4 });
            //context.HospitalDepartments.Add(new Entities.HospitalDepartment { HospitalId = 2, DepartmentId = 2 });


        }
    }
}
