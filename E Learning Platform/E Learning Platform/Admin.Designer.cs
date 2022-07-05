namespace E_Learning_Platform
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new Guna.UI2.WinForms.Guna2Button();
            this.buttonViewUser = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.Administrator = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Dashboard1 = new E_Learning_Platform.Admin_UC.UC_Dashboard();
            this.uC_AddUser1 = new E_Learning_Platform.Admin_UC.UC_AddUser();
            this.uC_ViewUser1 = new E_Learning_Platform.Admin_UC.UC_ViewUser();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonLogout);
            this.panel1.Controls.Add(this.buttonViewUser);
            this.panel1.Controls.Add(this.buttonAddUser);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.Administrator);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 726);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonLogout.CheckedState.Parent = this.buttonLogout;
            this.buttonLogout.CustomImages.Parent = this.buttonLogout;
            this.buttonLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogout.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.HoverState.BorderColor = System.Drawing.Color.Black;
            this.buttonLogout.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.buttonLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.buttonLogout.HoverState.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonLogout.HoverState.Parent = this.buttonLogout;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonLogout.Location = new System.Drawing.Point(68, 609);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.PressedColor = System.Drawing.Color.Beige;
            this.buttonLogout.ShadowDecoration.Parent = this.buttonLogout;
            this.buttonLogout.Size = new System.Drawing.Size(180, 45);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonViewUser
            // 
            this.buttonViewUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonViewUser.CheckedState.Parent = this.buttonViewUser;
            this.buttonViewUser.CustomImages.Parent = this.buttonViewUser;
            this.buttonViewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonViewUser.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewUser.ForeColor = System.Drawing.Color.White;
            this.buttonViewUser.HoverState.BorderColor = System.Drawing.Color.SeaShell;
            this.buttonViewUser.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.buttonViewUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonViewUser.HoverState.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonViewUser.HoverState.Parent = this.buttonViewUser;
            this.buttonViewUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonViewUser.Image")));
            this.buttonViewUser.ImageSize = new System.Drawing.Size(50, 50);
            this.buttonViewUser.Location = new System.Drawing.Point(40, 500);
            this.buttonViewUser.Name = "buttonViewUser";
            this.buttonViewUser.PressedColor = System.Drawing.Color.Beige;
            this.buttonViewUser.ShadowDecoration.Color = System.Drawing.SystemColors.WindowText;
            this.buttonViewUser.ShadowDecoration.Parent = this.buttonViewUser;
            this.buttonViewUser.Size = new System.Drawing.Size(208, 60);
            this.buttonViewUser.TabIndex = 3;
            this.buttonViewUser.Text = "View User";
            this.buttonViewUser.Click += new System.EventHandler(this.buttonViewUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonAddUser.CheckedState.Parent = this.buttonAddUser;
            this.buttonAddUser.CustomImages.Parent = this.buttonAddUser;
            this.buttonAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddUser.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonAddUser.ForeColor = System.Drawing.Color.White;
            this.buttonAddUser.HoverState.BorderColor = System.Drawing.Color.Black;
            this.buttonAddUser.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.buttonAddUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddUser.HoverState.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAddUser.HoverState.Parent = this.buttonAddUser;
            this.buttonAddUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddUser.Image")));
            this.buttonAddUser.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonAddUser.Location = new System.Drawing.Point(40, 418);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.PressedColor = System.Drawing.Color.Beige;
            this.buttonAddUser.ShadowDecoration.Parent = this.buttonAddUser;
            this.buttonAddUser.Size = new System.Drawing.Size(208, 45);
            this.buttonAddUser.TabIndex = 2;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonDashboard.CheckedState.Parent = this.buttonDashboard;
            this.buttonDashboard.CustomImages.Parent = this.buttonDashboard;
            this.buttonDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDashboard.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.HoverState.BorderColor = System.Drawing.Color.Black;
            this.buttonDashboard.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.buttonDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDashboard.HoverState.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.buttonDashboard.HoverState.Parent = this.buttonDashboard;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageSize = new System.Drawing.Size(45, 45);
            this.buttonDashboard.Location = new System.Drawing.Point(40, 315);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.PressedColor = System.Drawing.Color.Beige;
            this.buttonDashboard.ShadowDecoration.Parent = this.buttonDashboard;
            this.buttonDashboard.Size = new System.Drawing.Size(208, 56);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // Administrator
            // 
            this.Administrator.AutoSize = true;
            this.Administrator.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrator.ForeColor = System.Drawing.Color.White;
            this.Administrator.Location = new System.Drawing.Point(32, 237);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(248, 44);
            this.Administrator.TabIndex = 1;
            this.Administrator.Text = "Administrator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.uC_Dashboard1);
            this.panel2.Controls.Add(this.uC_AddUser1);
            this.panel2.Controls.Add(this.uC_ViewUser1);
            this.panel2.Location = new System.Drawing.Point(303, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 726);
            this.panel2.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // uC_Dashboard1
            // 
            this.uC_Dashboard1.BackColor = System.Drawing.Color.White;
            this.uC_Dashboard1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Dashboard1.Location = new System.Drawing.Point(0, 3);
            this.uC_Dashboard1.Name = "uC_Dashboard1";
            this.uC_Dashboard1.Size = new System.Drawing.Size(1179, 722);
            this.uC_Dashboard1.TabIndex = 0;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_AddUser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.uC_AddUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddUser1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1176, 726);
            this.uC_AddUser1.TabIndex = 2;
            // 
            // uC_ViewUser1
            // 
            this.uC_ViewUser1.BackColor = System.Drawing.Color.White;
            this.uC_ViewUser1.Location = new System.Drawing.Point(0, 3);
            this.uC_ViewUser1.Name = "uC_ViewUser1";
            this.uC_ViewUser1.Size = new System.Drawing.Size(1176, 723);
            this.uC_ViewUser1.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.White;
            this.userNameLabel.Location = new System.Drawing.Point(91, 678);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(89, 39);
            this.userNameLabel.TabIndex = 3;
            this.userNameLabel.Text = "name";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 726);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Administrator;
        private Guna.UI2.WinForms.Guna2Button buttonLogout;
        private Guna.UI2.WinForms.Guna2Button buttonViewUser;
        private Guna.UI2.WinForms.Guna2Button buttonAddUser;
        private Guna.UI2.WinForms.Guna2Button buttonDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Admin_UC.UC_Dashboard uC_Dashboard1;
        private Admin_UC.UC_ViewUser uC_ViewUser1;
        private Admin_UC.UC_AddUser uC_AddUser1;
        private System.Windows.Forms.Label userNameLabel;
    }
}