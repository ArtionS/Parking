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
    public partial class Parkings : Form
    {
        private string idUser = "";
        ConexionBD bd = null;
        public Parkings(string id)
        {
            InitializeComponent();
            idUser = id;
            bd = new ConexionBD();
        }

        private void btnBackParking_Click(object sender, EventArgs e)
        {
            using (MainScreen newWindow = new MainScreen(idUser))
            {
                this.Visible = false;
                newWindow.ShowDialog();
                this.Close();
            }
        }

        private void addParkingsToList()
        {
            string query = "select id_parking, name, address, size from parkings;";
            List<string>[] parkingList = new List<string>[3];

            parkingList = bd.Select(query, "id_parking", "name", "address", "size");
            int parkingQuantity = parkingList[0].Count;
            
            if (parkingQuantity <= 0)
            {
                MessageBox.Show("Contacte al administrador para solucionar el problema.", "No hay estacionamientos agregados.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < parkingQuantity; i++)
                {
                    int j = 1;
                    ListViewItem parking = new ListViewItem((string)parkingList[j].ToArray().GetValue(i));  // El primero en la lista horizontal
                    j++;                                                                                    // Se debe aumentar uno para que el siguiente subitem no se repita
                    for (; j < 4; j++)
                    {
                        parking.SubItems.Add((string)parkingList[j].ToArray().GetValue(i));                 // Itera sobre las columnas, y los agrega como subitems del item primero
                    }
                    listViewParkings.Items.Add(parking);                                                    // Se agrega la columna entera a la lista
                }
            }
        }

        private void Parkings_Load(object sender, EventArgs e)
        {
            addParkingsToList();
        }
    }
}
