namespace E_Learning_Platform
{
    partial class ChangePassword
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
            this.TextBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.TextBoxnewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.textBoxUsernameAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxConfirmPassword
            // 
            this.TextBoxConfirmPassword.Location = new System.Drawing.Point(294, 188);
            this.TextBoxConfirmPassword.Multiline = true;
            this.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword";
            this.TextBoxConfirmPassword.Size = new System.Drawing.Size(248, 28);
            this.TextBoxConfirmPassword.TabIndex = 8;
            // 
            // TextBoxnewPassword
            // 
            this.TextBoxnewPassword.Location = new System.Drawing.Point(294, 115);
            this.TextBoxnewPassword.Multiline = true;
            this.TextBoxnewPassword.Name = "TextBoxnewPassword";
            this.TextBoxnewPassword.Size = new System.Drawing.Size(248, 28);
            this.TextBoxnewPassword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(59, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "New password  :";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonChangePassword.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.buttonChangePassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonChangePassword.Location = new System.Drawing.Point(294, 258);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(171, 37);
            this.buttonChangePassword.TabIndex = 9;
            this.buttonChangePassword.Text = "set password";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // textBoxUsernameAdmin
            // 
            this.textBoxUsernameAdmin.Location = new System.Drawing.Point(294, 45);
            this.textBoxUsernameAdmin.Multiline = true;
            this.textBoxUsernameAdmin.Name = "textBoxUsernameAdmin";
            this.textBoxUsernameAdmin.Size = new System.Drawing.Size(248, 28);
            this.textBoxUsernameAdmin.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(112, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username :";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.Controls.Add(this.textBoxUsernameAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.TextBoxConfirmPassword);
            this.Controls.Add(this.TextBoxnewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxConfirmPassword;
        private System.Windows.Forms.TextBox TextBoxnewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.TextBox textBoxUsernameAdmin;
        private System.Windows.Forms.Label label3;
    }
}