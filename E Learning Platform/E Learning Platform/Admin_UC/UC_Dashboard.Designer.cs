namespace E_Learning_Platform.Admin_UC
{
    partial class UC_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelApplied = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelRegistered = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(78, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 42);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dashboard";
            // 
            // labelApplied
            // 
            this.labelApplied.AutoSize = true;
            this.labelApplied.BackColor = System.Drawing.Color.Black;
            this.labelApplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplied.ForeColor = System.Drawing.Color.White;
            this.labelApplied.Location = new System.Drawing.Point(105, 85);
            this.labelApplied.Name = "labelApplied";
            this.labelApplied.Size = new System.Drawing.Size(43, 46);
            this.labelApplied.TabIndex = 11;
            this.labelApplied.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(37, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Total application ";
            // 
            // labelRegistered
            // 
            this.labelRegistered.AutoSize = true;
            this.labelRegistered.BackColor = System.Drawing.Color.Black;
            this.labelRegistered.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistered.ForeColor = System.Drawing.Color.White;
            this.labelRegistered.Location = new System.Drawing.Point(106, 85);
            this.labelRegistered.Name = "labelRegistered";
            this.labelRegistered.Size = new System.Drawing.Size(43, 46);
            this.labelRegistered.TabIndex = 9;
            this.labelRegistered.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total registration";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.CheckedState.Parent = this.buttonRefresh;
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.CustomImages.Parent = this.buttonRefresh;
            this.buttonRefresh.FillColor = System.Drawing.Color.White;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.HoverState.FillColor = System.Drawing.Color.White;
            this.buttonRefresh.HoverState.Parent = this.buttonRefresh;
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonRefresh.Location = new System.Drawing.Point(350, 76);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.PressedColor = System.Drawing.Color.White;
            this.buttonRefresh.ShadowDecoration.Parent = this.buttonRefresh;
            this.buttonRefresh.Size = new System.Drawing.Size(45, 44);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.UseTransparentBackground = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(323, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelRegistered);
            this.panel1.Location = new System.Drawing.Point(246, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 161);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.labelApplied);
            this.panel2.Location = new System.Drawing.Point(679, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 161);
            this.panel2.TabIndex = 17;
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1179, 726);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelApplied;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelRegistered;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
