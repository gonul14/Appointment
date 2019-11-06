using Randevu.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Randevu.Entities;

namespace Randevu.WinFormUI
{
    public partial class PrescriptionList : Form
    {
        public PrescriptionList()
        {
            InitializeComponent();
        }

        private void PrescriptionList_Load(object sender, EventArgs e)
        {
            lbPrescriptionList.Visible = true;
        }

        private void btnPrescriptionList_Click(object sender, EventArgs e)
        {
            lbPrescriptionList.Items.Clear();
            PrescriptionController prescriptionController = new PrescriptionController();
            List<Entities.Prescription> prescriptions = prescriptionController.GetAll();
            int.TryParse(txtPrescriptionNo.Text, out int prescriptionNo);
            foreach (Entities.Prescription item in prescriptions)
            {
                
                if (item.PrescriptionId == prescriptionNo)
                {
                    lbPrescriptionList.Items.Add(item.Description);
                    return;
                }


            }
            MessageBox.Show("Böyle bir reçete bulunmamaktadır.");
        }

        private void txtPrescriptionNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
