using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ParkingCucei
{
    class ConexionBD
    {
        private string connectionString = ConfigurationManager.AppSettings.Get("connectionString");
        MySqlConnection con = null;
        private bool connected = false;

        public ConexionBD()
        {
            try
            {
                con = new MySqlConnection(connectionString);
                con.Open();

                connected = con.State == ConnectionState.Open ? true : false;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool GetConnectionState()
        {
            return connected;
        }

        private bool OpenConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Insert(string queryInsert)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(queryInsert, con);
                cmd.ExecuteNonQuery(); // Revisar por si acaso
                this.CloseConnection();
            }
        }

        public void Update(string queryUpdate)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(queryUpdate, con);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public void Delete(string queryDelete)
        {
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(queryDelete, con);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public string SelectOne(string querySelect)
        {
            string selected = "";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(querySelect, con);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    selected = dataReader.GetString(0);
                }
                dataReader.Close();

                this.CloseConnection();

                return selected;
            }
            else
            {
                return selected = "";
            }
        }

        public int Count(string queryCount)
        {
            int count = -1;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(queryCount, con);
                // El scalar regresa solo un valor
                count = int.Parse(cmd.ExecuteScalar()+"");
                this.CloseConnection();
                return count;
            }
            else
            {
                return count;
            }
        }

    }
}
