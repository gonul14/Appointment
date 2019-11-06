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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        public int userRole;
        public static int userID;
        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeAppointment makeAppointment = new MakeAppointment();
            makeAppointment.ShowDialog();
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userID = 0;
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();

            randevuAlToolStripMenuItem.Visible = true;
            randevularToolStripMenuItem.Visible = true;
            çıkışToolStripMenuItem.Visible = true;
            çalışmaGünüToolStripMenuItem.Visible = false;
            reçeteSorgulaToolStripMenuItem.Visible = false;
            reçeteGeçmişiToolStripMenuItem.Visible = false;


            if (userRole == (int)User.UserType.Doctor)
            {
                çalışmaGünüToolStripMenuItem.Visible = true;
            }
            else if (userRole == (int)User.UserType.Pharmacist)
            {
                reçeteSorgulaToolStripMenuItem.Visible = true;
                reçeteGeçmişiToolStripMenuItem.Visible = true;
            }
        }

        private void çalışmaGünüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkingDay workingDay = new WorkingDay();
            workingDay.ShowDialog();
        }

        private void reçeteSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrescriptionList prescriptionList = new PrescriptionList();
            prescriptionList.ShowDialog();
        }

        private void reçeteGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BeforePrescription beforePrescription = new BeforePrescription();
            beforePrescription.ShowDialog();
        }

    }
}
