using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingCucei
{
    public partial class EditUser : Form
    {
        string idUser = "";
        ConexionBD bd = null;
        public EditUser(string id)
        {
            InitializeComponent();
            idUser = id;
            bd = new ConexionBD();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            using (MainScreen newWindow = new MainScreen(idUser))
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private bool searhUsersDB()
        {
            string queryFetch = "select id_user, fname, lname, email, passwd from users where id_user = " + idUser + ";";

            string fName = "", lName = "", email = "";

            List<string>[] dataList = new List<string>[3];

            dataList = bd.Select(queryFetch, "id_user", "fName", "lName", "email");

            if (dataList[0].Count <= 0)
            {
                MessageBox.Show("Fallo al recuperar datos del usuario.", "No se pudieron recuerar los datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                fName = (string)dataList[1].ToArray().GetValue(0);
                lName = (string)dataList[2].ToArray().GetValue(0);
                email = (string)dataList[3].ToArray().GetValue(0);

                txtEmail.Text = email;
                txtFName.Text = fName;
                txtLName.Text = lName;

                return true;
            }
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            if (!searhUsersDB())
            {
                using (MainScreen newWindow = new MainScreen(idUser))
                {
                    this.Visible = false;
                    newWindow.ShowDialog();
                    this.Close();
                }
            }
        }

        private void deleteUser()
        {
            string queryDel = "DELETE FROM users WHERE id_user = " + idUser + ";";

            if (bd.Delete(queryDel))
            {
                MessageBox.Show("Se eliminó exitosamente el usuario", "Usuario eliminado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                using (Login newWindow = new Login())
                {
                    this.Visible = false;
                    newWindow.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }

        private void btnGuardarModificacion_Click(object sender, EventArgs e)
        {
            updateUser();
            txtPasswd.Text = "";
            txtNewPasswd.Text = "";
        }

        private void updateUser()
        {
            string queryUpdate = "";

            string userFName = txtFName.Text;
            string userLName = txtLName.Text;
            string userEmail = txtEmail.Text;
            string userNewPass = txtNewPasswd.Text;

            if (txtNewPasswd.Text == "") // En caso de que se deje vacio es porque no se cambiara la contraseña, por lo tanto no se necesita la seguridad para el cambio de contraseña
            {
                queryUpdate = "UPDATE users SET id_user = " + idUser + ", fname = '" + userFName + "', lname = '" + userLName + "', email = '" + userEmail + "' WHERE id_user = " + idUser + ";";
            }
            else // Verificar que la contraseña previa sea la correcta
            {
                if (checkCurrentPasswd())
                {
                    queryUpdate = "UPDATE users SET id_user = " + idUser + ", fname = '" + userFName + "', lname = '" + userLName + "', email = '" + userEmail + "',  passwd = sha2('" + userNewPass + "', 256) WHERE id_user = " + idUser + ";";
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
                bool isMatch = userCode == idUser ? true : false;
                return isMatch;
            }
            return false;
        }

    }
}
