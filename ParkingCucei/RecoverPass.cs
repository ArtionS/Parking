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
        private string senderMail = ConfigurationManager.AppSettings.Get("senderMail");
        private string passSender = ConfigurationManager.AppSettings.Get("pass");
        ConexionBD bd = null;

        public FPasswd()
        {
            InitializeComponent();
            bd = new ConexionBD();
        }

        private void btnFPass_Click(object sender, EventArgs e)
        {
            // Se revisa si el usuario existe y en caso de que si se guarda en la variable mail recover
            string mailRecover = checkUserID();

            // En caso de que no exista el usuario la cadena se encontrara vacia
            if (mailRecover == "")
            {
                MessageBox.Show("El codigo de usuario no existe.", "Codigo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Se genera una contraseña nueva y se guarda en la variable newpass
                string newPass = RandomString(8);

                if (checkInternetConnection())
                {
                    // Cambia la contraseña dentro de la base de datos
                    if (changePasswordDB(newPass))
                    {
                        // Manda un correo con la nueva contraseña y al destinatario que este registrado dentro de ese usuario
                        recoverPassword(newPass, mailRecover);
                    }
                    else
                    {
                        MessageBox.Show("Error al cambiar la contraseña en base de datos", "Error al actualizar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo establecer la conexión a internet.", "Error al conectar con red", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Cierra la ventana para volver al login
                using (Login newWindow = new Login())
                {
                    this.Visible = false;
                    newWindow.ShowDialog();
                    this.Close();
                }

            }
        }

        private string checkUserID()
        {
            string codeRecover = txtFPass.Text;
            string queryFetch = "SELECT email FROM users WHERE id_user='" + codeRecover + "';";
            string mailRecover = "";

            return mailRecover = bd.SelectOne(queryFetch);
        }

        private bool changePasswordDB(string randomPass)
        {
            string codeRecover = txtFPass.Text;
            string queryRecover = "update users set passwd = sha2('" + randomPass + "', 256) where id_user = '" + codeRecover + "';";

            if (bd.Update(queryRecover))
                return true;
            else
                return false;
        }

        private void recoverPassword(string newPass, string userMail)
        {
            string to, from, pass;
            MailMessage message = new MailMessage();
            to = userMail;
            from = senderMail;
            pass = passSender;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "<img src=\"https://raw.githubusercontent.com/ROALOCH/cucei-park-db/master/src/Resources/emailHeader.png \" /><br><h1 style=font-family: Arial, Helvetica, sans-serif; font-size: 30px; padding-left: 300px; <strong>" + newPass + "</strong></h1>";
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
        private bool checkInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
