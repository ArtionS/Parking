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
        private string idToWork = "";
        ConexionBD bd = null;

        public CreateUser()
        {
            InitializeComponent();
            bd = new ConexionBD();
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

            if (bd.Insert(queryAdd))
            {
                MessageBox.Show("Se agregó exitosamente el usuario", "Usuario agregado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al insertar el usuario", "Error al agregar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void clearBoxes()
        {
            txtCode.Text = "";
            txtEmail.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtPasswd.Text = "";
            txtNewPasswd.Text = "";

            idToWork = "";
        }

        private void deleteUser()
        {
            Console.WriteLine(idToWork);
            if (idToWork != "")
            {
                string queryDel = "DELETE FROM users WHERE id_user = " + idToWork + ";";

                if (bd.Delete(queryDel))
                    MessageBox.Show("Se eliminó exitosamente el usuario", "Usuario eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    MessageBox.Show("Error al eliminar el usuario", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Problemas al encontrar el identificador del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateUser()
        {
            string queryUpdate = "";

            string userCode = txtCode.Text;
            string userFName = txtFName.Text;
            string userLName = txtLName.Text;
            string userEmail = txtEmail.Text;
            string userNewPass = txtNewPasswd.Text;

            if (txtNewPasswd.Text == "") // En caso de que se deje vacio es porque no se cambiara la contraseña, por lo tanto no se necesita la seguridad para el cambio de contraseña
            {
                queryUpdate = "UPDATE users SET id_user = " + userCode + ", fname = '" + userFName + "', lname = '" + userLName + "', email = '" + userEmail + "' WHERE id_user = " + idToWork + ";";
            }
            else // Verificar que la contraseña previa sea la correcta
            {
                if (checkCurrentPasswd())
                {
                    queryUpdate = "UPDATE users SET id_user = " + userCode + ", fname = '" + userFName + "', lname = '" + userLName + "', email = '" + userEmail + "',  passwd = sha2('" + userNewPass +"', 256) WHERE id_user = " + idToWork + ";";
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta, no se permite modificar contraseña si la actual no es correcta", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Ejecutar modificacion de usuario en la base de datos

            if (bd.Update(queryUpdate))
                MessageBox.Show("Se modificó exitosamente el usuario", "Usuario modificado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Error al modifcar el usuario", "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private bool checkCurrentPasswd()
        {
            string queryCheck = "SELECT id_user FROM users WHERE passwd = sha2('" + txtPasswd.Text + "', 256);";
            string userCode = "";

            userCode = bd.SelectOne(queryCheck);

            if (userCode != "")
            {
                // Se revisa si el id que se consiguio con la contraseña es el que se esta trabajando
                bool isMatch = userCode == idToWork ? true : false;
                return isMatch;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Login newWindow = new Login())
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }
    }
}
