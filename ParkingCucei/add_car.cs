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
    public partial class add_car : Form
    {
        private string idUser = "";
        public add_car(string id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            using (show_cars newWindow = new show_cars(idUser))
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }
    }
}
