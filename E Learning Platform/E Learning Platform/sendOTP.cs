using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace E_Learning_Platform
{
    public partial class sendOTP : Form
    {
        String OTPCode;
        public static String to;
        public sendOTP()
        {
            InitializeComponent();
        }

        private void buttonSendOTP_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            OTPCode = (rand.Next(999999)).ToString();

            MailMessage message = new MailMessage();
            to = (TextboxOTPEmail.Text).ToString();
            from = "otp12test@gmail.com";
            pass = "34b20f25-9ff7-4854-942b-9fcb54a5c3a3";
            messageBody = "Your Reset OTP is " + OTPCode;

            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password reset code";

            SmtpClient smtp = new SmtpClient("smtp.gmass.co");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code sent successfully.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVerifyOTP_Click(object sender, EventArgs e)
        {
            if (OTPCode == (TextboxOTPCode.Text).ToString())
            {
                to = TextboxOTPEmail.Text;
                //MessageBox.Show("Password changed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangePassword cp = new ChangePassword();
                cp.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Please enter correct code.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
