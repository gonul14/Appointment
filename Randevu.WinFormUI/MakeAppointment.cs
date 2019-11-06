using Randevu.BLL;
using Randevu.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Randevu.WinFormUI
{
    public partial class MakeAppointment : Form
    {
        public MakeAppointment()
        {
            InitializeComponent();
        }

        PolyclinicController polyclinicController;
        HospitalController hospitalController;
        AppointmentController appointmentController;
        HourController hourController;
        HospitalDepartmentController hospitalDepartmentController;
        UserController userController;
        DepartmentController departmentController;
        List<Hospital> hospitals;
        List<Polyclinic> polyclinics;
        List<HospitalDepartment> hospitalDepartments;
        List<User> users;
        List<Hour> hours;
        List<Department> departments;

        private void MakeAppointment_Load(object sender, EventArgs e)
        {
            dtpAppointmentDate.MinDate = DateTime.Today;

            hospitalController = new HospitalController();
            hospitals = hospitalController.GetAll();

            cmbHospital.DataSource = hospitals;
            cmbHospital.DisplayMember = "HospitalName";
            cmbHospital.ValueMember = "HospitalId";

            cmbHospital.Text = string.Empty;

            cmbDoctor.SelectedIndex = -1;
            cmbPolyclinic.Items.Clear();
            AllDepartments();
        }

        private void AllDepartments()
        {
            departmentController = new DepartmentController();
            departments = departmentController.GetAll();

            cmbDepartment.DataSource = departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentId";

            cmbDepartment.Text = string.Empty;
        }

        private void cmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPolyclinic.Items.Clear();
            cmbPolyclinic.Text = string.Empty; 
            cmbDepartment.Text = string.Empty;

            polyclinicController = new PolyclinicController();
            polyclinics = polyclinicController.GetAll();
            int hospitalId = ((Hospital)(cmbHospital.SelectedItem)).HospitalId;
            foreach (Polyclinic polyclinic in polyclinics)
            {
                if (polyclinic.HospitalId == hospitalId)
                {
                    cmbPolyclinic.Items.Add(polyclinic.PolyclinicName);
                }
            }

            hospitalDepartmentController = new HospitalDepartmentController();
            hospitalDepartments = hospitalDepartmentController.GetAll();


            foreach (HospitalDepartment department in hospitalDepartments)
            {
                appointmentController = new AppointmentController();
                cmbDepartment.DataSource = appointmentController.ListDepartment(hospitalId);
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "DepartmentId";
            }
            cmbDoctor.SelectedIndex = -1;
            cmbDoctor.Text = string.Empty;
            cmbHour.DataSource = null;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.DataSource = null;
            userController = new UserController();
            users = userController.GetAll();
            hospitalDepartmentController = new HospitalDepartmentController();
            hospitalDepartments = hospitalDepartmentController.GetAll();            
            int departmentId = Convert.ToInt32(((Department)(cmbDepartment.SelectedItem)).DepartmentId);
            int hospitalId = Convert.ToInt32(((Hospital)(cmbHospital.SelectedItem)).HospitalId);
            userController = new UserController();
            cmbDoctor.DataSource = userController.ListDoctor(hospitalId,departmentId);
            cmbDoctor.DisplayMember = "FirstName";
            cmbDoctor.ValueMember = "UserId";
            cmbDoctor.Text = string.Empty;
            cmbDoctor.SelectedIndex = -1;
            cmbHour.DataSource = null;
        }

        private void btnMakeAppointment_Click(object sender, EventArgs e)
        {
            if (cmbHospital.SelectedItem != null & cmbDoctor.SelectedItem != null & cmbDepartment.SelectedItem != null & cmbHour.SelectedItem != null)
            {
                appointmentController = new AppointmentController();
                Appointment appointment = new Appointment();
                appointment.DoctorId = Convert.ToInt32(cmbDoctor.SelectedValue);
                appointment.AppointmentDate = dtpAppointmentDate.Value/*.Date*/;
                appointment.HourId = ((Hour)(cmbHour.SelectedItem)).HourId;
                appointment.PatientId = Homepage.userID;

                appointmentController.Add(appointment);
                MessageBox.Show("Randevunuz kaydedilmiştir.");
                ClearAppointments();
            }
            else
                MessageBox.Show("Lütfen alanları doldurunuz.");

        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoctor.SelectedItem != null)
            {
                int doctorId = ((User)(cmbDoctor.SelectedItem)).UserId;
                DateTime selectedDate = dtpAppointmentDate.Value.Date;
                DateTime selectedDate2 = dtpAppointmentDate.Value.Date.AddDays(1);
                hourController = new HourController();
                hours = hourController.GetAll();
                appointmentController = new AppointmentController();
                var listHour = appointmentController.Hours(hours, doctorId, selectedDate, selectedDate2);
                if (listHour.Count>0)
                {
                    cmbHour.DataSource = listHour;
                    cmbHour.DisplayMember = "HourInfo";
                    cmbHour.ValueMember = "HourId";
                }
            }
            cmbHour.Text = string.Empty;
        }
        private void ClearAppointments()
        {
            dtpAppointmentDate.Value = DateTime.Today;
            Clear();
        }

        private void DtpAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            Clear();
            AllDepartments();
        }

        private void Clear()
        {
            cmbHospital.Text = string.Empty;
            cmbDepartment.Text = string.Empty;
            cmbDoctor.Text = string.Empty;
            cmbHour.Text = string.Empty;
            cmbPolyclinic.Text = string.Empty;
            cmbHour.DataSource = null;
            cmbPolyclinic.Items.Clear();
            cmbDoctor.DataSource = null;
        }
    }
}
