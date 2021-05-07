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
        string currentUserID = "";

        public MainScreen(string idUser)
        {
            InitializeComponent();
            currentUserID = idUser;
            lblCode.Text = "Bienvenido! " + currentUserID;
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

        private void btnMyCars_Click(object sender, EventArgs e)
        {
            using (show_cars newWindow = new show_cars(currentUserID))
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            using (Tickets newWindow = new Tickets(currentUserID))
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }

        private void btnViewParking_Click(object sender, EventArgs e)
        {
            using (Parkings newWindow = new Parkings(currentUserID))
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
