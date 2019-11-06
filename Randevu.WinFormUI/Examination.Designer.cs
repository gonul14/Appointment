namespace Randevu.WinFormUI
{
    partial class Examination
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
            this.radioAppointmentStatusTrue = new System.Windows.Forms.RadioButton();
            this.radioAppointmentStatusFalse = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDiagnosis = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.radioButtonNeedTestFalse = new System.Windows.Forms.RadioButton();
            this.radioButtonNeedTestTrue = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnMakeAppointment = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPolyclinic = new System.Windows.Forms.ComboBox();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpAddAppointment = new System.Windows.Forms.GroupBox();
            this.btnAddPrescription = new System.Windows.Forms.Button();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpAddAppointment.SuspendLayout();
            this.groupBoxStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioAppointmentStatusTrue
            // 
            this.radioAppointmentStatusTrue.AutoSize = true;
            this.radioAppointmentStatusTrue.Checked = true;
            this.radioAppointmentStatusTrue.Location = new System.Drawing.Point(36, 21);
            this.radioAppointmentStatusTrue.Margin = new System.Windows.Forms.Padding(4);
            this.radioAppointmentStatusTrue.Name = "radioAppointmentStatusTrue";
            this.radioAppointmentStatusTrue.Size = new System.Drawing.Size(62, 21);
            this.radioAppointmentStatusTrue.TabIndex = 1;
            this.radioAppointmentStatusTrue.TabStop = true;
            this.radioAppointmentStatusTrue.Text = "Geldi";
            this.radioAppointmentStatusTrue.UseVisualStyleBackColor = true;
            // 
            // radioAppointmentStatusFalse
            // 
            this.radioAppointmentStatusFalse.AutoSize = true;
            this.radioAppointmentStatusFalse.Location = new System.Drawing.Point(116, 21);
            this.radioAppointmentStatusFalse.Margin = new System.Windows.Forms.Padding(4);
            this.radioAppointmentStatusFalse.Name = "radioAppointmentStatusFalse";
            this.radioAppointmentStatusFalse.Size = new System.Drawing.Size(81, 21);
            this.radioAppointmentStatusFalse.TabIndex = 2;
            this.radioAppointmentStatusFalse.Text = "Gelmedi";
            this.radioAppointmentStatusFalse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teşhis:";
            // 
            // cmbDiagnosis
            // 
            this.cmbDiagnosis.FormattingEnabled = true;
            this.cmbDiagnosis.Location = new System.Drawing.Point(147, 69);
            this.cmbDiagnosis.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiagnosis.Name = "cmbDiagnosis";
            this.cmbDiagnosis.Size = new System.Drawing.Size(200, 24);
            this.cmbDiagnosis.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 162);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // radioButtonNeedTestFalse
            // 
            this.radioButtonNeedTestFalse.AutoSize = true;
            this.radioButtonNeedTestFalse.Checked = true;
            this.radioButtonNeedTestFalse.Location = new System.Drawing.Point(107, 25);
            this.radioButtonNeedTestFalse.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNeedTestFalse.Name = "radioButtonNeedTestFalse";
            this.radioButtonNeedTestFalse.Size = new System.Drawing.Size(57, 21);
            this.radioButtonNeedTestFalse.TabIndex = 8;
            this.radioButtonNeedTestFalse.TabStop = true;
            this.radioButtonNeedTestFalse.Text = "Hayır";
            this.radioButtonNeedTestFalse.UseCompatibleTextRendering = true;
            this.radioButtonNeedTestFalse.UseVisualStyleBackColor = true;
            this.radioButtonNeedTestFalse.CheckedChanged += new System.EventHandler(this.RadioButtonNeedTestFalse_CheckedChanged);
            // 
            // radioButtonNeedTestTrue
            // 
            this.radioButtonNeedTestTrue.AutoSize = true;
            this.radioButtonNeedTestTrue.Location = new System.Drawing.Point(27, 22);
            this.radioButtonNeedTestTrue.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonNeedTestTrue.Name = "radioButtonNeedTestTrue";
            this.radioButtonNeedTestTrue.Size = new System.Drawing.Size(57, 21);
            this.radioButtonNeedTestTrue.TabIndex = 7;
            this.radioButtonNeedTestTrue.Text = "Evet";
            this.radioButtonNeedTestTrue.UseVisualStyleBackColor = true;
            this.radioButtonNeedTestTrue.UseWaitCursor = true;
            this.radioButtonNeedTestTrue.CheckedChanged += new System.EventHandler(this.RadioButtonNeedTestTrue_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Randevu Tarihi:";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(132, 32);
            this.dtpAppointmentDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(235, 22);
            this.dtpAppointmentDate.TabIndex = 24;
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.Location = new System.Drawing.Point(268, 215);
            this.btnMakeAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(100, 28);
            this.btnMakeAppointment.TabIndex = 23;
            this.btnMakeAppointment.Text = "Randevu Al";
            this.btnMakeAppointment.UseVisualStyleBackColor = true;
            this.btnMakeAppointment.Click += new System.EventHandler(this.BtnMakeAppointment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Randevu Saati:";
            // 
            // cmbHour
            // 
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Location = new System.Drawing.Point(132, 182);
            this.cmbHour.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(235, 24);
            this.cmbHour.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Doktor:";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(132, 151);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(235, 24);
            this.cmbDoctor.TabIndex = 19;
            this.cmbDoctor.SelectedIndexChanged += new System.EventHandler(this.CmbDoctor_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Departman:";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(132, 121);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(235, 24);
            this.cmbDepartment.TabIndex = 17;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.CmbDepartment_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Poliklinik:";
            // 
            // cmbPolyclinic
            // 
            this.cmbPolyclinic.FormattingEnabled = true;
            this.cmbPolyclinic.Location = new System.Drawing.Point(132, 90);
            this.cmbPolyclinic.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPolyclinic.Name = "cmbPolyclinic";
            this.cmbPolyclinic.Size = new System.Drawing.Size(235, 24);
            this.cmbPolyclinic.TabIndex = 14;
            // 
            // cmbHospital
            // 
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Location = new System.Drawing.Point(132, 60);
            this.cmbHospital.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(235, 24);
            this.cmbHospital.TabIndex = 15;
            this.cmbHospital.SelectedIndexChanged += new System.EventHandler(this.CmbHospital_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Hastane: ";
            // 
            // grpAddAppointment
            // 
            this.grpAddAppointment.Controls.Add(this.btnMakeAppointment);
            this.grpAddAppointment.Controls.Add(this.label6);
            this.grpAddAppointment.Controls.Add(this.label9);
            this.grpAddAppointment.Controls.Add(this.dtpAppointmentDate);
            this.grpAddAppointment.Controls.Add(this.cmbHospital);
            this.grpAddAppointment.Controls.Add(this.cmbPolyclinic);
            this.grpAddAppointment.Controls.Add(this.label5);
            this.grpAddAppointment.Controls.Add(this.label8);
            this.grpAddAppointment.Controls.Add(this.cmbHour);
            this.grpAddAppointment.Controls.Add(this.cmbDepartment);
            this.grpAddAppointment.Controls.Add(this.label4);
            this.grpAddAppointment.Controls.Add(this.label7);
            this.grpAddAppointment.Controls.Add(this.cmbDoctor);
            this.grpAddAppointment.Location = new System.Drawing.Point(17, 198);
            this.grpAddAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddAppointment.Name = "grpAddAppointment";
            this.grpAddAppointment.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddAppointment.Size = new System.Drawing.Size(396, 245);
            this.grpAddAppointment.TabIndex = 26;
            this.grpAddAppointment.TabStop = false;
            this.grpAddAppointment.Text = "Randevu Al";
            // 
            // btnAddPrescription
            // 
            this.btnAddPrescription.Location = new System.Drawing.Point(135, 162);
            this.btnAddPrescription.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPrescription.Name = "btnAddPrescription";
            this.btnAddPrescription.Size = new System.Drawing.Size(115, 28);
            this.btnAddPrescription.TabIndex = 27;
            this.btnAddPrescription.Text = "Reçete Oluştur";
            this.btnAddPrescription.UseVisualStyleBackColor = true;
            this.btnAddPrescription.Click += new System.EventHandler(this.btnAddPrescription_Click);
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.radioAppointmentStatusTrue);
            this.groupBoxStatus.Controls.Add(this.radioAppointmentStatusFalse);
            this.groupBoxStatus.Location = new System.Drawing.Point(19, 12);
            this.groupBoxStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxStatus.Size = new System.Drawing.Size(349, 50);
            this.groupBoxStatus.TabIndex = 28;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = "Durum";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNeedTestFalse);
            this.groupBox1.Controls.Add(this.radioButtonNeedTestTrue);
            this.groupBox1.Location = new System.Drawing.Point(17, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(365, 54);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tahlil Gerekli Mi?";
            // 
            // Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.btnAddPrescription);
            this.Controls.Add(this.grpAddAppointment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbDiagnosis);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Examination";
            this.Text = "Muayene";
            this.Load += new System.EventHandler(this.Examination_Load);
            this.grpAddAppointment.ResumeLayout(false);
            this.grpAddAppointment.PerformLayout();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioAppointmentStatusTrue;
        private System.Windows.Forms.RadioButton radioAppointmentStatusFalse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDiagnosis;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radioButtonNeedTestFalse;
        private System.Windows.Forms.RadioButton radioButtonNeedTestTrue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Button btnMakeAppointment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPolyclinic;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpAddAppointment;
        private System.Windows.Forms.Button btnAddPrescription;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}