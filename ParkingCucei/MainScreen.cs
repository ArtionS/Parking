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
    public partial class MainScreen : Form
    {
        string currentUser = "";
        public MainScreen(string userName)
        {
            InitializeComponent();
            currentUser = userName;
            lblWelcome.Text = "Bienvenido! " + currentUser;
        }

        private void btnVolverLogin_Click(object sender, EventArgs e)
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
