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
    public partial class CreateUser : Form
    {
        private string connectionString = ConfigurationManager.AppSettings.Get("connectionString");

        public CreateUser()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if(txtCode.Text == "" || txtFName.Text == "" || txtLName.Text == "" || txtEmail.Text == "" || txtPasswd.Text == "")
            {
                MessageBox.Show("Falto llenar campos\no estos fueron demasiado largos.", "Campos vacios o demasiados largos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addUserDB();
                clearBoxes();
            }
        }

        private void addUserDB()
        {
            string userCode = txtCode.Text;
            string userFName = txtFName.Text;
            string userLName = txtLName.Text;
            string userEmail = txtEmail.Text;
            string userPasswd = txtPasswd.Text;

            string queryAdd = "INSERT INTO users (id_user, fname, lname, email, passwd) values(" + userCode + ", '" + userFName + "', '" + userLName + "', '" + userEmail + "', sha2('" + userPasswd +"', 256));" ;

            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                con.Open();

                MySqlCommand command = new MySqlCommand(queryAdd, con);

                MySqlDataReader reader = command.ExecuteReader();

                con.Close();
                MessageBox.Show("Se agregó exitosamente el usuario", "Usuario agregado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearBoxes()
        {
            txtCode.Text = "";
            txtEmail.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtPasswd.Text = "";
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (searhUsersDB())
            {
                btnGuardarModificacion.Enabled = true;
                btnEliminarUsuario.Enabled = true;
                btnAgregarUsuario.Enabled = false;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.", "Codigo no encontrado.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool searhUsersDB()
        {
            string idToSearch = txtBuscar.Text;
            string queryFetch = "select fname, lname, email, passwd from users where id_user = " + idToSearch + ";";

            string fName = "", lName = "", email = "";

            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                con.Open();

                MySqlCommand command = new MySqlCommand(queryFetch, con);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        fName = reader.GetString(0);
                        lName = reader.GetString(1);
                        email = reader.GetString(2);
                    }
                    con.Close();

                    txtCode.Text = idToSearch;
                    txtEmail.Text = email;
                    txtFName.Text = fName;
                    txtLName.Text = lName;

                    return true;
                }

                con.Close();

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
    }
}
