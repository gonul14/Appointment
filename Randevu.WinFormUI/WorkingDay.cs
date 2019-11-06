using Randevu.BLL;
using Randevu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu.WinFormUI
{
    public partial class WorkingDay : Form
    {
        public WorkingDay()
        {
            InitializeComponent();
        }
        
        AppointmentController appointmentController;
        private void btnAddExamination_Click(object sender, EventArgs e)
        {
            if (lstAppointment.SelectedItems.Count > 0)
            {
                ListViewItem item = lstAppointment.SelectedItems[0];                
                Examination.appointmentID =Convert.ToInt32(item.SubItems[0].Text);
                Examination examination = new Examination();
                examination.ShowDialog();
                Hide();
            }
            else
            {
                MessageBox.Show("Lütfen ilgili randevuyu seçiniz.");
            }
        }

        private void WorkingDay_Load(object sender, EventArgs e)
        {      
            lstAppointment.View = View.Details; 
            lstAppointment.GridLines = true; 
            lstAppointment.FullRowSelect = true;
            lstAppointment.Columns.Add("No", 50);
            lstAppointment.Columns.Add("Ad", 50);
            lstAppointment.Columns.Add("Soyad", 50);
            lstAppointment.Columns.Add("Saat", 50);
            lstAppointment.Columns.Add("Tarih", 100);
        }

        private void BtnAppointmentList_Click(object sender, EventArgs e)
        {
            if (dtpAppointmentDate.Value == DateTime.Today)
            {
                btnAddExamination.Enabled = true;
            }
            else
            {
                btnAddExamination.Enabled = false;

            }
            lstAppointment.Items.Clear();
            appointmentController = new AppointmentController();
            List<Appointment> appointments = appointmentController.GetAll();
            foreach (var item in appointments)
            {
                if (item.AppointmentDate.Date == dtpAppointmentDate.Value.Date & item.DoctorId==Homepage.userID)
                {
                    ListViewItem listViewItems = new ListViewItem(item.AppointmentId.ToString());
                    listViewItems.SubItems.Add(item.Patient.FirstName);
                    listViewItems.SubItems.Add(item.Patient.LastName);
                    listViewItems.SubItems.Add(item.Hour.HourInfo);
                    listViewItems.SubItems.Add(item.AppointmentDate.Date.ToString());
                    lstAppointment.Items.Add(listViewItems);
                }
            }
        }
        
    }
}
