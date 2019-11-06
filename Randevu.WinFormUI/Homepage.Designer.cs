namespace Randevu.WinFormUI
{
    partial class Homepage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randevuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışmaGünüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteGeçmişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserAccount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuAlToolStripMenuItem,
            this.randevularToolStripMenuItem,
            this.çalışmaGünüToolStripMenuItem,
            this.reçeteSorgulaToolStripMenuItem,
            this.reçeteGeçmişiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(50, 80, 50, 20);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(728, 124);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randevuAlToolStripMenuItem
            // 
            this.randevuAlToolStripMenuItem.Name = "randevuAlToolStripMenuItem";
            this.randevuAlToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.randevuAlToolStripMenuItem.Text = "Randevu Al";
            this.randevuAlToolStripMenuItem.Click += new System.EventHandler(this.randevuAlToolStripMenuItem_Click);
            // 
            // randevularToolStripMenuItem
            // 
            this.randevularToolStripMenuItem.Name = "randevularToolStripMenuItem";
            this.randevularToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.randevularToolStripMenuItem.Text = "Randevular";
            this.randevularToolStripMenuItem.Click += new System.EventHandler(this.randevularToolStripMenuItem_Click);
            // 
            // çalışmaGünüToolStripMenuItem
            // 
            this.çalışmaGünüToolStripMenuItem.Name = "çalışmaGünüToolStripMenuItem";
            this.çalışmaGünüToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.çalışmaGünüToolStripMenuItem.Text = "Çalışma Günü";
            this.çalışmaGünüToolStripMenuItem.Click += new System.EventHandler(this.çalışmaGünüToolStripMenuItem_Click);
            // 
            // reçeteSorgulaToolStripMenuItem
            // 
            this.reçeteSorgulaToolStripMenuItem.Name = "reçeteSorgulaToolStripMenuItem";
            this.reçeteSorgulaToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.reçeteSorgulaToolStripMenuItem.Text = "Reçete Sorgula";
            this.reçeteSorgulaToolStripMenuItem.Click += new System.EventHandler(this.reçeteSorgulaToolStripMenuItem_Click);
            // 
            // reçeteGeçmişiToolStripMenuItem
            // 
            this.reçeteGeçmişiToolStripMenuItem.Name = "reçeteGeçmişiToolStripMenuItem";
            this.reçeteGeçmişiToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.reçeteGeçmişiToolStripMenuItem.Text = "Reçete Geçmişi";
            this.reçeteGeçmişiToolStripMenuItem.Click += new System.EventHandler(this.reçeteGeçmişiToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cambria", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastane Randevu Sistemi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::Randevu.WinFormUI.Properties.Resources.health_png_image_hd_png_mart_health_png_png_800_531__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserAccount
            // 
            this.lblUserAccount.AutoSize = true;
            this.lblUserAccount.Location = new System.Drawing.Point(596, 28);
            this.lblUserAccount.Name = "lblUserAccount";
            this.lblUserAccount.Size = new System.Drawing.Size(0, 17);
            this.lblUserAccount.TabIndex = 3;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 327);
            this.Controls.Add(this.lblUserAccount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Homepage";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevuAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışmaGünüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteGeçmişiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserAccount;
    }
}