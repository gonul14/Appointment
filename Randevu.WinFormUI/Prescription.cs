using Randevu.BLL;
using System;
using System.Windows.Forms;

namespace Randevu.WinFormUI
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }
        PrescriptionController prescriptionController;
        public static int appointmentID;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = txtPrescription.Text;
            if (description.Length > 0)
            {
                prescriptionController = new PrescriptionController();
                Entities.Prescription prescription = new Entities.Prescription();
                prescription.Description = txtPrescription.Text;
                prescription.ExaminationId = Examination.examinationID;
                prescriptionController.Add(prescription);
                int prescriptionNo = prescription.PrescriptionId;

                MessageBox.Show("Reçete Numarası: " + prescriptionNo);
                Hide();
            }
            else
                MessageBox.Show("Lütfen reçete bilgilerini doldurunuz.");

        }
        int counter;
        private void Prescription_Load(object sender, EventArgs e)
        {
            txtPrescription.MaxLength = 500;
            counter = txtPrescription.MaxLength;
            lblCounter.Text = counter.ToString();
        }

        private void txtPrescription_TextChanged(object sender, EventArgs e)
        {
            
            lblCounter.Text =(counter - txtPrescription.Text.Length).ToString();
        }
    }
}
