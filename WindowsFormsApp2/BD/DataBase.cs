using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2.BD
{
    class DataBase
    {
        MySqlConnectionStringBuilder builderConexion;
        MySqlConnection conexionString;
        MySqlDataReader reader;
        MySqlCommand command;
        
        public DataBase()
        {
            createConexion();
        }
        public void createConexion()
        {
            try
            {
                builderConexion = new MySqlConnectionStringBuilder();
                builderConexion.Server = "localhost";
                builderConexion.Port = 3306;
                builderConexion.UserID = "root";
                builderConexion.Password = "";
                builderConexion.Database = "barberiabarbaros";

                conexionString = new MySqlConnection(builderConexion.ConnectionString);
                
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        public MySqlDataReader EjecutarSelect(string query)
        {
            command = new MySqlCommand(query, conexionString);

            try
            {
                conexionString.Open();
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexionString.Close();
                return null;
            }
        }
        public void closeConnection()
        {
            conexionString.Close();
        }

        public bool EjecutarQuery(string query)
        {
            try
            {
                conexionString.Open();
                command = new MySqlCommand(query, conexionString);
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public DataTable FillCombobox()
        {
            string query = "select ";
            command= new MySqlCommand()
        }
    }
}
