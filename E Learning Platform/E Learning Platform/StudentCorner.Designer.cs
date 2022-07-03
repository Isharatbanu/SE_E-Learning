namespace E_Learning_Platform
{
    partial class StudentCorner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentCorner));
            this.HomeButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.HomeButton.CheckedState.Parent = this.HomeButton;
            this.HomeButton.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.HomeButton.HoverState.Parent = this.HomeButton;
            this.HomeButton.ImageRotate = 0F;
            this.HomeButton.Location = new System.Drawing.Point(720, 1);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.HomeButton.PressedState.Parent = this.HomeButton;
            this.HomeButton.Size = new System.Drawing.Size(80, 72);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.Location = new System.Drawing.Point(716, 12);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(72, 67);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHome.TabIndex = 1;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // StudentCorner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxHome);
            this.Controls.Add(this.HomeButton);
            this.Name = "StudentCorner";
            this.Text = "StudentCorner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton HomeButton;
        private System.Windows.Forms.PictureBox pictureBoxHome;
    }
}