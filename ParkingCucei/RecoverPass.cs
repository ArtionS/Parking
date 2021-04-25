using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace ParkingCucei
{
    public partial class FPasswd : Form
    {
        public FPasswd()
        {
            InitializeComponent();
        }

        private void btnFPass_Click(object sender, EventArgs e)
        {
            String r = RandomString(8);
            lblCodeRecover.Text = r;
            // recoverPassword();
        }

        private void checkUserID()
        {

        }

        private void changePasswordDB()
        {

        }

        private void recoverPassword()
        {
            string to, from, pass, messageBody;
            MailMessage message = new MailMessage();
            to = "lglvluislopez@gmail.com";
            from = "parkdbcucei@gmail.com";
            pass = "parkdbcu";
            messageBody = "Para cambiar contraseña";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "From: " + "<br>Messsage: " + messageBody;
            message.Subject = "Cambio de contraseña";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Correo enviado exitosamente.", "enviado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static string RandomString(int length)
        {
            Random random = new Random();
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var builder = new StringBuilder();

            for (var i = 0; i < length; i++)
            {
                var c = pool[random.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }
    }
}
