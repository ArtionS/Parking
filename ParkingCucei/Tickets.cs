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
    public partial class Tickets : Form
    {
        private string idUser = "";
        public Tickets(string id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void btnBackTickets_Click(object sender, EventArgs e)
        {
            using (MainScreen newWindow = new MainScreen(idUser))
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }
    }
}
