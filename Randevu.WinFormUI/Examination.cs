using Randevu.BLL;
using Randevu.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Randevu.WinFormUI
{
    public partial class Examination : Form
    {
        public Examination()
        {
            InitializeComponent();
        }
        public static int appointmentID;
        public static int examinationID;
        ExaminationController examinationController = new ExaminationController();
        
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
        int doctorID;
        private void Examination_Load(object sender, EventArgs e)
        {
            btnAddPrescription.Enabled = false;
            dtpAppointmentDate.MinDate = DateTime.Today;

            grpAddAppointment.Visible = false;
            doctorID = Homepage.userID;

            examinationController = new ExaminationController();
            var doctorList = examinationController.Examination(doctorID);
            cmbDiagnosis.DataSource = doctorList;
            cmbDiagnosis.DisplayMember = "DiagnosisName";
            cmbDiagnosis.ValueMember = "DiagnosisId";
            cmbDiagnosis.Text = string.Empty;
            cmbDiagnosis.SelectedIndex = -1;

            hospitalController = new HospitalController();
            hospitals = hospitalController.GetAll();

            cmbHospital.DataSource = hospitals;
            cmbHospital.DisplayMember = "HospitalName";
            cmbHospital.ValueMember = "HospitalId";

            cmbHospital.Text = string.Empty;

            cmbDoctor.SelectedIndex = -1;
            cmbPolyclinic.Items.Clear();

        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbDiagnosis.SelectedItem != null)
            {
                ExaminationSave();
                MessageBox.Show("Muayene işlemi başarıyla kaydedildi.");
                btnAddPrescription.Enabled = true;
                Clear();
                btnSave.Enabled = false;
            }
            else
                MessageBox.Show("Teşhisi belirlemeniz gerekiyor.");
        }

        private void ExaminationSave()
        {
            examinationController = new ExaminationController();
            Entities.Examination examination = new Entities.Examination();
            examination.AppointmentId = appointmentID;
            if (radioAppointmentStatusTrue.Checked)
                examination.IsValid = true;
            else
                examination.IsValid = false;
            examination.DiagnosisId = ((Entities.Diagnosis)cmbDiagnosis.SelectedItem).DiagnosisId;
            if (radioButtonNeedTestTrue.Checked)
                examination.IsNeedTest = true;
            else
                examination.IsNeedTest = false;
            examinationController.Add(examination);
            examinationID = examination.ExaminationId;
        }

        private void CmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbDoctor.DataSource = null;

            userController = new UserController();
            users = userController.GetAll();

            hospitalDepartmentController = new HospitalDepartmentController();
            hospitalDepartments = hospitalDepartmentController.GetAll();

            int departmentId = Convert.ToInt32(((Department)(cmbDepartment.SelectedItem)).DepartmentId);
            int hospitalId = Convert.ToInt32(((Hospital)(cmbHospital.SelectedItem)).HospitalId);
            userController = new UserController();
            cmbDoctor.DataSource = userController.ListDoctor(hospitalId, departmentId);
            cmbDoctor.DisplayMember = "FirstName";
            cmbDoctor.ValueMember = "UserId";
            cmbDoctor.Text = string.Empty;
            cmbDoctor.SelectedIndex = -1;
            cmbHour.DataSource = null;
        }
        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
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
                if (listHour.Count > 0)
                {
                    cmbHour.DataSource = listHour;
                    cmbHour.DisplayMember = "HourInfo";
                    cmbHour.ValueMember = "HourId";
                }
            }
            cmbHour.Text = string.Empty;
        }

        private void BtnMakeAppointment_Click(object sender, EventArgs e)
        {
            if (cmbHospital.SelectedItem != null & cmbDoctor.SelectedItem != null & cmbDepartment.SelectedItem != null & cmbHour.SelectedItem != null)
            {
                List<int> patientID = examinationController.ExaminationPatientId(appointmentID);

                appointmentController = new AppointmentController();
                Appointment appointment = new Appointment();
                appointment.DoctorId = Homepage.userID;
                appointment.AppointmentDate = dtpAppointmentDate.Value;
                appointment.HourId = ((Hour)(cmbHour.SelectedItem)).HourId;
                appointment.PatientId = Convert.ToInt32(patientID[0]);

                appointmentController.Add(appointment);

                ExaminationSave();
                MessageBox.Show("Hastanız için gerekli randevu oluşturuldu.");
                Clear();
            }
            else
                MessageBox.Show("Lütfen gerekli alanları doldurunuz.");

        }

        private void CmbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPolyclinic.Items.Clear();
            cmbPolyclinic.Text = string.Empty;

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

        private void RadioButtonNeedTestTrue_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            grpAddAppointment.Visible = true;
            btnAddPrescription.Enabled = false;
            cmbDiagnosis.DataSource = null;

            departmentController = new DepartmentController();
            departments = departmentController.GetAll();

            cmbDepartment.DataSource = departments;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentId";

            cmbDepartment.Text = string.Empty;


        }

        private void RadioButtonNeedTestFalse_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            grpAddAppointment.Visible = false;
            btnAddPrescription.Enabled = false;
            grpAddAppointment.Visible = false;
            examinationController = new ExaminationController();
            var doctorList = examinationController.Examination(doctorID);
            cmbDiagnosis.DataSource = doctorList;
            cmbDiagnosis.DisplayMember = "DiagnosisName";
            cmbDiagnosis.ValueMember = "DiagnosisId";
            cmbDiagnosis.Text = string.Empty;
            cmbDiagnosis.SelectedIndex = -1;
        }

        private void Clear()
        {
            cmbDiagnosis.Text = string.Empty;
            radioButtonNeedTestFalse.Checked = true;
            dtpAppointmentDate.Value = DateTime.Today;
            cmbHospital.Text = string.Empty;
            cmbDepartment.Text = string.Empty;
            cmbDoctor.Text = string.Empty;
            cmbHour.Text = string.Empty;
            cmbPolyclinic.Text = string.Empty;
            cmbHour.DataSource = null;
            cmbPolyclinic.Items.Clear();
            cmbDoctor.DataSource = null;
            cmbDiagnosis.DataSource = null;
        }

    }
}
