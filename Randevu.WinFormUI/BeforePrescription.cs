using Randevu.BLL;
using System;
using System.Windows.Forms;

namespace Randevu.WinFormUI
{
    public partial class BeforePrescription : Form
    {
        public BeforePrescription()
        {
            InitializeComponent();
        }
        PrescriptionController prescriptionController;
        private void btnPrescriptions_Click(object sender, EventArgs e)
        {
            prescriptionController = new PrescriptionController();
            string identityNo = txtIdentity.Text;
            if (identityNo.Length == 11)
                dgvPrescriptionList.DataSource = prescriptionController.BeforePrescription(identityNo);
            else
            {
                MessageBox.Show("Doğru bir TC No girdiğinizden emin olunuz.");
                identityNo = string.Empty;
            }
        }

        private void txtIdentity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BeforePrescription_Load(object sender, EventArgs e)
        {
            txtIdentity.MaxLength = 11;
        }
    }
}
