using Randevu.BLL;
using Randevu.Entities;
using System;
using System.Windows.Forms;

namespace Randevu.WinFormUI
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }
        AppointmentController appointmentController;
        Appointment appointment;
        private void Appointments_Load(object sender, EventArgs e)
        {
            RefreshAppointment();

        }

        private void RefreshAppointment()
        {
            appointmentController = new AppointmentController();
            int userId = Homepage.userID;

            var list = appointmentController.ListAppointment(userId);
            dgvAppointmentList.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointmentList.RowCount > 0)
            {
                int appointmentId = (int)dgvAppointmentList.SelectedRows[0].Cells[0].Value;
                DialogResult dialogResult = MessageBox.Show("Randevuyu silmek istediğinize emin misiniz?", "Randevu Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    appointment = new Appointment() { AppointmentId = appointmentId };
                    appointmentController.DeleteById(appointment);
                    RefreshAppointment();
                }
            }
            else
                MessageBox.Show("Randevunuz bulunmamaktadır.");

        }
    }
}
