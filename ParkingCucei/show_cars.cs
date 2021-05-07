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
    public partial class show_cars : Form
    {
        private string idUser = "";
        public show_cars(string id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            using (MainScreen newWindow = new MainScreen(idUser))
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }

        private void btn_add_new_car_Click(object sender, EventArgs e)
        {
            using (add_car newWindow = new add_car(idUser))
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }
    }
}
