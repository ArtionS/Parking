using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParkingCucei
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=12345");
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
    }
}
