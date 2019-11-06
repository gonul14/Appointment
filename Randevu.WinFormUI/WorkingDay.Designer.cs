namespace Randevu.WinFormUI
{
    partial class WorkingDay
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
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnAppointmentList = new System.Windows.Forms.Button();
            this.lstAppointment = new System.Windows.Forms.ListView();
            this.btnAddExamination = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevu Tarihi:";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(136, 12);
            this.dtpAppointmentDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(223, 22);
            this.dtpAppointmentDate.TabIndex = 1;
            this.dtpAppointmentDate.Value = new System.DateTime(2019, 10, 30, 0, 0, 0, 0);
            // 
            // btnAppointmentList
            // 
            this.btnAppointmentList.Location = new System.Drawing.Point(368, 10);
            this.btnAppointmentList.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppointmentList.Name = "btnAppointmentList";
            this.btnAppointmentList.Size = new System.Drawing.Size(161, 28);
            this.btnAppointmentList.TabIndex = 3;
            this.btnAppointmentList.Text = "Randevuları Listele";
            this.btnAppointmentList.UseVisualStyleBackColor = true;
            this.btnAppointmentList.Click += new System.EventHandler(this.BtnAppointmentList_Click);
            // 
            // lstAppointment
            // 
            this.lstAppointment.Location = new System.Drawing.Point(13, 49);
            this.lstAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.lstAppointment.Name = "lstAppointment";
            this.lstAppointment.Size = new System.Drawing.Size(507, 253);
            this.lstAppointment.TabIndex = 4;
            this.lstAppointment.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddExamination
            // 
            this.btnAddExamination.Location = new System.Drawing.Point(368, 310);
            this.btnAddExamination.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddExamination.Name = "btnAddExamination";
            this.btnAddExamination.Size = new System.Drawing.Size(161, 28);
            this.btnAddExamination.TabIndex = 5;
            this.btnAddExamination.Text = "Muayene Oluştur";
            this.btnAddExamination.UseVisualStyleBackColor = true;
            this.btnAddExamination.Click += new System.EventHandler(this.btnAddExamination_Click);
            // 
            // WorkingDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 352);
            this.Controls.Add(this.btnAddExamination);
            this.Controls.Add(this.lstAppointment);
            this.Controls.Add(this.btnAppointmentList);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkingDay";
            this.Text = "Randevu Listesi";
            this.Load += new System.EventHandler(this.WorkingDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button btnAppointmentList;
        private System.Windows.Forms.ListView lstAppointment;
        private System.Windows.Forms.Button btnAddExamination;
    }
}