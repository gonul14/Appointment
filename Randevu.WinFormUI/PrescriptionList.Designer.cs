namespace Randevu.WinFormUI
{
    partial class PrescriptionList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrescriptionNo = new System.Windows.Forms.TextBox();
            this.btnPrescriptionList = new System.Windows.Forms.Button();
            this.lbPrescriptionList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete No:";
            // 
            // txtPrescriptionNo
            // 
            this.txtPrescriptionNo.Location = new System.Drawing.Point(81, 10);
            this.txtPrescriptionNo.Name = "txtPrescriptionNo";
            this.txtPrescriptionNo.Size = new System.Drawing.Size(175, 20);
            this.txtPrescriptionNo.TabIndex = 1;
            this.txtPrescriptionNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrescriptionNo_KeyPress);
            // 
            // btnPrescriptionList
            // 
            this.btnPrescriptionList.Location = new System.Drawing.Point(164, 38);
            this.btnPrescriptionList.Name = "btnPrescriptionList";
            this.btnPrescriptionList.Size = new System.Drawing.Size(92, 23);
            this.btnPrescriptionList.TabIndex = 3;
            this.btnPrescriptionList.Text = "Reçeteyi Getir";
            this.btnPrescriptionList.UseVisualStyleBackColor = true;
            this.btnPrescriptionList.Click += new System.EventHandler(this.btnPrescriptionList_Click);
            // 
            // lbPrescriptionList
            // 
            this.lbPrescriptionList.FormattingEnabled = true;
            this.lbPrescriptionList.Location = new System.Drawing.Point(16, 72);
            this.lbPrescriptionList.Name = "lbPrescriptionList";
            this.lbPrescriptionList.Size = new System.Drawing.Size(240, 173);
            this.lbPrescriptionList.TabIndex = 4;
            // 
            // PrescriptionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 250);
            this.Controls.Add(this.lbPrescriptionList);
            this.Controls.Add(this.btnPrescriptionList);
            this.Controls.Add(this.txtPrescriptionNo);
            this.Controls.Add(this.label1);
            this.Name = "PrescriptionList";
            this.Text = "Reçete";
            this.Load += new System.EventHandler(this.PrescriptionList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrescriptionNo;
        private System.Windows.Forms.Button btnPrescriptionList;
        private System.Windows.Forms.ListBox lbPrescriptionList;
    }
}