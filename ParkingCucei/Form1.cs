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
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.AppSettings.Get("connectionString");

        public Form1()
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
    }
}
