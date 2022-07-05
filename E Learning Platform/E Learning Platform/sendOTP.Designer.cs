namespace E_Learning_Platform
{
    partial class sendOTP
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.TextboxOTPEmail = new System.Windows.Forms.TextBox();
            this.TextboxOTPCode = new System.Windows.Forms.TextBox();
            this.buttonSendOTP = new System.Windows.Forms.Button();
            this.buttonVerifyOTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(81, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verify code :";
            // 
            // TextboxOTPEmail
            // 
            this.TextboxOTPEmail.Location = new System.Drawing.Point(300, 92);
            this.TextboxOTPEmail.Multiline = true;
            this.TextboxOTPEmail.Name = "TextboxOTPEmail";
            this.TextboxOTPEmail.Size = new System.Drawing.Size(248, 28);
            this.TextboxOTPEmail.TabIndex = 3;
            // 
            // TextboxOTPCode
            // 
            this.TextboxOTPCode.Location = new System.Drawing.Point(300, 168);
            this.TextboxOTPCode.Multiline = true;
            this.TextboxOTPCode.Name = "TextboxOTPCode";
            this.TextboxOTPCode.Size = new System.Drawing.Size(248, 28);
            this.TextboxOTPCode.TabIndex = 4;
            // 
            // buttonSendOTP
            // 
            this.buttonSendOTP.BackColor = System.Drawing.Color.Teal;
            this.buttonSendOTP.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendOTP.ForeColor = System.Drawing.Color.White;
            this.buttonSendOTP.Location = new System.Drawing.Point(601, 85);
            this.buttonSendOTP.Name = "buttonSendOTP";
            this.buttonSendOTP.Size = new System.Drawing.Size(114, 44);
            this.buttonSendOTP.TabIndex = 5;
            this.buttonSendOTP.Text = "Send OTP";
            this.buttonSendOTP.UseVisualStyleBackColor = false;
            this.buttonSendOTP.Click += new System.EventHandler(this.buttonSendOTP_Click);
            // 
            // buttonVerifyOTP
            // 
            this.buttonVerifyOTP.BackColor = System.Drawing.Color.Teal;
            this.buttonVerifyOTP.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerifyOTP.ForeColor = System.Drawing.Color.White;
            this.buttonVerifyOTP.Location = new System.Drawing.Point(601, 161);
            this.buttonVerifyOTP.Name = "buttonVerifyOTP";
            this.buttonVerifyOTP.Size = new System.Drawing.Size(114, 44);
            this.buttonVerifyOTP.TabIndex = 6;
            this.buttonVerifyOTP.Text = "Verify OTP";
            this.buttonVerifyOTP.UseVisualStyleBackColor = false;
            this.buttonVerifyOTP.Click += new System.EventHandler(this.buttonVerifyOTP_Click);
            // 
            // sendOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 253);
            this.Controls.Add(this.buttonVerifyOTP);
            this.Controls.Add(this.buttonSendOTP);
            this.Controls.Add(this.TextboxOTPCode);
            this.Controls.Add(this.TextboxOTPEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sendOTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sendOTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextboxOTPEmail;
        private System.Windows.Forms.TextBox TextboxOTPCode;
        private System.Windows.Forms.Button buttonSendOTP;
        private System.Windows.Forms.Button buttonVerifyOTP;
    }
}