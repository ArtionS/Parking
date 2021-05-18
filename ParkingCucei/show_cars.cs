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
        ConexionBD bd = null;
        public show_cars(string id)
        {
            InitializeComponent();
            idUser = id;
            bd = new ConexionBD();
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

        private void show_cars_Load(object sender, EventArgs e)
        {
            addCarsList();
        }

        private void addCarsList()
        {
            string query = "select plate, brand, model, color from cars where id_user = " + idUser +";";
            int carsQuantity = 0;
            List<string>[] carList = new List<string>[3];

            carList = bd.Select(query, "plate", "brand", "model", "color");
            carsQuantity = carList[0].Count;
            if (carsQuantity <= 0)
            {
                MessageBox.Show("Agregue un auto para poder mostrarlo.", "No se tienen autos agregados.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < carsQuantity; i++)
                {
                    int j = 0;
                    ListViewItem car = new ListViewItem((string)carList[j].ToArray().GetValue(i));  // El primero en la lista horizontal
                    j++;                                                                            // Se debe aumentar uno para que el siguiente subitem no se repita
                    for (; j < 4; j++)
                    {
                        car.SubItems.Add((string)carList[j].ToArray().GetValue(i));                 // Itera sobre las columnas, y los agrega como subitems del item primero
                    }
                    listViewCars.Items.Add(car);                                                    // Se agrega la columna entera a la lista
                }
            }
        }
    }
}
