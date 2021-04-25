using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace ParkingCucei
{
    public partial class Login : Form
    {
        private string connectionString = ConfigurationManager.AppSettings.Get("connectionString");
        private string username = "";

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                
                if(con.State == ConnectionState.Open)
                {
                    label1.Text = "conectado";
                    label1.ForeColor = Color.Green;
                }
                else
                {
                    label1.Text = "No conectado";
                    label1.ForeColor = Color.Red;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btnConfirm = MessageBoxButtons.OK;

            switch (loginCheck())
            {
                case 0:
                    {
                        MessageBox.Show("Codigo o contraseña incorrectos.", "Datos incorrectos", btnConfirm);
                        break;
                    }
                case 1:
                    {
                        using (MainScreen newWindow = new MainScreen(username))
                        {
                            this.Visible = false;
                            newWindow.ShowDialog();
                            this.Close();
                        }
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Falto llenar campos\no estos fueron demasiado largos.", "Campos vacios o demasiados largos.", btnConfirm);
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("El nombre de usuario cuenta con caracteres diferentes a numeros.", "Caracteres diferentes de numeros ingresados.", btnConfirm);
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Sucedio un error\nIntentar nuevamente.", "Error.", btnConfirm);
                        break;
                    }
            }
        }

        private int loginCheck()
        {
            if (txtCode.Text == "" || txtPasswd.Text == "" || txtCode.Text.Length > 10 || txtPasswd.Text.Length > 63)
            {
                return 2;
            }

            if (!Regex.IsMatch(txtCode.Text, @"^[0-9]+$"))
            {
                return 3;
            }

            // Conseguir los datos de los textbox
            string code = txtCode.Text;
            string password = txtPasswd.Text;

            // Crear query para que utilice los datos ingresados y solo regresa el nombre del  usuario
            string queryFetch = "SELECT fname FROM users WHERE (id_user='" + code + "'AND passwd=sha2('" + password + "', 256))";


            try
            {
                // Crear conexion
                MySqlConnection con = new MySqlConnection(connectionString);

                // Abrir conexion
                con.Open();

                // Crear objeto comando con el query y la conexion
                MySqlCommand command = new MySqlCommand(queryFetch, con);

                // Crear objeto reader para guardar el resultado de la ejecucion del comando
                MySqlDataReader reader = command.ExecuteReader();

                // Revisar si se retorno algo
                if (reader.HasRows)
                {
                    // Leer lo que se regreso
                    while (reader.Read())
                    {
                        username = reader.GetString(0);
                    }
                    con.Close();
                    return 1;
                }
                
                // Cerrar la conexion
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        private void lblFPass_Click(object sender, EventArgs e)
        {
            using (FPasswd newWindow = new FPasswd())
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }

        private void lblCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (CreateUser newWindow = new CreateUser())
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }
    }
}
