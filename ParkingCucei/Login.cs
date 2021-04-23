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

namespace ParkingCucei
{
    public partial class Login : Form
    {
        private string connectionString = ConfigurationManager.AppSettings.Get("connectionString");

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
            // Conseguir los datos de los textbox
            string code = txtUsername.Text;
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
                        lblConfirmation.Text = "Bienvenido usuario, " + reader.GetString(0);
                    }
                }

                // Cerrar la conexion
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
