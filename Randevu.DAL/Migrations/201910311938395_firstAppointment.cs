namespace Randevu.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstAppointment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointment",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        DoctorId = c.Int(),
                        HourId = c.Int(nullable: false),
                        AppointmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.User", t => t.DoctorId)
                .ForeignKey("dbo.Hour", t => t.HourId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.DoctorId)
                .Index(t => t.HourId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        IdentityNo = c.String(nullable: false, maxLength: 11),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 16),
                        BirthDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                        Gender = c.String(nullable: false, maxLength: 5),
                        PhoneNumber = c.String(),
                        UserRole = c.Int(nullable: false),
                        DepartmentId = c.Int(),
                        HospitalId = c.Int(),
                        IsValid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Department", t => t.DepartmentId)
                .ForeignKey("dbo.Hospital", t => t.HospitalId)
                .Index(t => t.DepartmentId)
                .Index(t => t.HospitalId);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Hospital",
                c => new
                    {
                        HospitalId = c.Int(nullable: false, identity: true),
                        HospitalName = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.HospitalId);
            
            CreateTable(
                "dbo.Hour",
                c => new
                    {
                        HourId = c.Int(nullable: false, identity: true),
                        HourInfo = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.HourId);
            
            CreateTable(
                "dbo.Diagnosis",
                c => new
                    {
                        DiagnosisId = c.Int(nullable: false, identity: true),
                        DiagnosisName = c.String(nullable: false, maxLength: 100),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DiagnosisId)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Examination",
                c => new
                    {
                        ExaminationId = c.Int(nullable: false, identity: true),
                        AppointmentId = c.Int(nullable: false),
                        IsValid = c.Boolean(nullable: false),
                        DiagnosisId = c.Int(nullable: false),
                        IsNeedTest = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ExaminationId)
                .ForeignKey("dbo.Appointment", t => t.AppointmentId, cascadeDelete: true)
                .ForeignKey("dbo.Diagnosis", t => t.DiagnosisId, cascadeDelete: true)
                .Index(t => t.AppointmentId)
                .Index(t => t.DiagnosisId);
            
            CreateTable(
                "dbo.HospitalDepartment",
                c => new
                    {
                        HospitalDepartmentId = c.Int(nullable: false, identity: true),
                        HospitalId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HospitalDepartmentId)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Hospital", t => t.HospitalId, cascadeDelete: true)
                .Index(t => t.HospitalId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.PolyclinicDepartment",
                c => new
                    {
                        PolyclinicDepartmentId = c.Int(nullable: false, identity: true),
                        PolyclinicId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PolyclinicDepartmentId)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Polyclinic", t => t.PolyclinicId, cascadeDelete: true)
                .Index(t => t.PolyclinicId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Polyclinic",
                c => new
                    {
                        PolyclinicId = c.Int(nullable: false, identity: true),
                        PolyclinicName = c.String(nullable: false, maxLength: 100),
                        HospitalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PolyclinicId)
                .ForeignKey("dbo.Hospital", t => t.HospitalId, cascadeDelete: true)
                .Index(t => t.HospitalId);
            
            CreateTable(
                "dbo.Prescription",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                        ExaminationId = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.PrescriptionId)
                .ForeignKey("dbo.Examination", t => t.ExaminationId, cascadeDelete: true)
                .Index(t => t.ExaminationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prescription", "ExaminationId", "dbo.Examination");
            DropForeignKey("dbo.PolyclinicDepartment", "PolyclinicId", "dbo.Polyclinic");
            DropForeignKey("dbo.Polyclinic", "HospitalId", "dbo.Hospital");
            DropForeignKey("dbo.PolyclinicDepartment", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.HospitalDepartment", "HospitalId", "dbo.Hospital");
            DropForeignKey("dbo.HospitalDepartment", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.Examination", "DiagnosisId", "dbo.Diagnosis");
            DropForeignKey("dbo.Examination", "AppointmentId", "dbo.Appointment");
            DropForeignKey("dbo.Diagnosis", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.Appointment", "PatientId", "dbo.User");
            DropForeignKey("dbo.Appointment", "HourId", "dbo.Hour");
            DropForeignKey("dbo.Appointment", "DoctorId", "dbo.User");
            DropForeignKey("dbo.User", "HospitalId", "dbo.Hospital");
            DropForeignKey("dbo.User", "DepartmentId", "dbo.Department");
            DropIndex("dbo.Prescription", new[] { "ExaminationId" });
            DropIndex("dbo.Polyclinic", new[] { "HospitalId" });
            DropIndex("dbo.PolyclinicDepartment", new[] { "DepartmentId" });
            DropIndex("dbo.PolyclinicDepartment", new[] { "PolyclinicId" });
            DropIndex("dbo.HospitalDepartment", new[] { "DepartmentId" });
            DropIndex("dbo.HospitalDepartment", new[] { "HospitalId" });
            DropIndex("dbo.Examination", new[] { "DiagnosisId" });
            DropIndex("dbo.Examination", new[] { "AppointmentId" });
            DropIndex("dbo.Diagnosis", new[] { "DepartmentId" });
            DropIndex("dbo.User", new[] { "HospitalId" });
            DropIndex("dbo.User", new[] { "DepartmentId" });
            DropIndex("dbo.Appointment", new[] { "HourId" });
            DropIndex("dbo.Appointment", new[] { "DoctorId" });
            DropIndex("dbo.Appointment", new[] { "PatientId" });
            DropTable("dbo.Prescription");
            DropTable("dbo.Polyclinic");
            DropTable("dbo.PolyclinicDepartment");
            DropTable("dbo.HospitalDepartment");
            DropTable("dbo.Examination");
            DropTable("dbo.Diagnosis");
            DropTable("dbo.Hour");
            DropTable("dbo.Hospital");
            DropTable("dbo.Department");
            DropTable("dbo.User");
            DropTable("dbo.Appointment");
        }
    }
}
