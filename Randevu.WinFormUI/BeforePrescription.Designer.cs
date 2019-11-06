namespace Randevu.WinFormUI
{
    partial class BeforePrescription
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
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.btnPrescriptions = new System.Windows.Forms.Button();
            this.dgvPrescriptionList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // txtIdentity
            // 
            this.txtIdentity.Location = new System.Drawing.Point(59, 10);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(117, 20);
            this.txtIdentity.TabIndex = 1;
            this.txtIdentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentity_KeyPress);
            // 
            // btnPrescriptions
            // 
            this.btnPrescriptions.Location = new System.Drawing.Point(197, 9);
            this.btnPrescriptions.Name = "btnPrescriptions";
            this.btnPrescriptions.Size = new System.Drawing.Size(75, 23);
            this.btnPrescriptions.TabIndex = 2;
            this.btnPrescriptions.Text = "Reçeteler";
            this.btnPrescriptions.UseVisualStyleBackColor = true;
            this.btnPrescriptions.Click += new System.EventHandler(this.btnPrescriptions_Click);
            // 
            // dgvPrescriptionList
            // 
            this.dgvPrescriptionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptionList.Location = new System.Drawing.Point(16, 38);
            this.dgvPrescriptionList.Name = "dgvPrescriptionList";
            this.dgvPrescriptionList.Size = new System.Drawing.Size(353, 150);
            this.dgvPrescriptionList.TabIndex = 3;
            // 
            // BeforePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 208);
            this.Controls.Add(this.dgvPrescriptionList);
            this.Controls.Add(this.btnPrescriptions);
            this.Controls.Add(this.txtIdentity);
            this.Controls.Add(this.label1);
            this.Name = "BeforePrescription";
            this.Text = "Eski Reçeteler";
            this.Load += new System.EventHandler(this.BeforePrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.Button btnPrescriptions;
        private System.Windows.Forms.DataGridView dgvPrescriptionList;
    }
}