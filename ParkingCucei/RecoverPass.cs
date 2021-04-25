using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;


namespace ParkingCucei
{
    public partial class FPasswd : Form
    {
        private string connectionString = ConfigurationManager.AppSettings.Get("connectionString");

        public FPasswd()
        {
            InitializeComponent();
        }

        private void btnFPass_Click(object sender, EventArgs e)
        {
            
            if (!checkUserID())
            {
                MessageBox.Show("El codigo de usuario no existe.", "Codigo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string newPass = RandomString(8);

            changePasswordDB(newPass);
            recoverPassword(newPass);

            using(Login newWindow = new Login())
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }

        private bool checkUserID()
        {
            string codeRecover = txtFPass.Text;
            string queryFetch = "SELECT fname FROM users WHERE id_user='" + codeRecover + "';";

            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                con.Open();

                MySqlCommand command = new MySqlCommand(queryFetch, con);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    con.Close();
                    return true;
                }
                
                return false;
                           }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void changePasswordDB(string randomPass)
        {
            string codeRecover = txtFPass.Text;
            string queryRecover = "update users set passwd = sha2('" + randomPass + "', 256) where id_user = '" + codeRecover +"';";

            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                con.Open();

                MySqlCommand command = new MySqlCommand(queryRecover, con);

                MySqlDataReader reader = command.ExecuteReader();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void recoverPassword(string newPass)
        {
            string to, from, pass, messageBody;
            MailMessage message = new MailMessage();
            to = "lglvluislopez@gmail.com";
            from = "parkdbcucei@gmail.com";
            pass = "parkdbcu";
            messageBody = "Se creo una contraseña aleatoria para entrar a su cuenta.<br>Su nueva contraseña es <strong>" + newPass + "<strong>";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "From: " + from + "<br>Messsage: " + messageBody;
            message.Subject = "Cambio de contraseña parkDB";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                DialogResult code = MessageBox.Show("Correo enviado exitosamente.\nVolviendo a pantalla login", "Nueva contraseña lista!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
