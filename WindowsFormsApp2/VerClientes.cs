using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.BD;
using WindowsFormsApp2.Clientes;
namespace WindowsFormsApp2
{
    public partial class VerClientes : Form
    {
        MySqlDataReader reader;
        List<ClassClientes> clientes = new List<ClassClientes>();
        DataBase DB;
        public VerClientes()
        {
            InitializeComponent();
        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            ObtenerClientes();
        }
        public void ObtenerClientes()
        {
            DB = new DataBase();
            string query = " select * from cliente";
            reader = DB.EjecutarSelect(query);
            if (reader.HasRows)
            {
                fillDatagridView();
            }

        }
        private void fillDatagridView()
        {
            dataGridView1.DataSource = null;
            while (reader.Read())
            {
                clientes.Add(
                    new ClassClientes
                    {
                        IdCliente = Convert.ToInt16( reader["IdCliente"]),
                        RfcCliente = Convert.ToString( reader["RfcCliente"]),
                        NombreCliente = Convert.ToString(reader["NombreCliente"]),
                        TelCliente = Convert.ToString(reader["TelCliente"]),
                        CorreoCliente = Convert.ToString(reader["CorreoCliente"]),

                    }
                    );
            }
            reader.Close();
            dataGridView1.DataSource = clientes;
            DB.closeConnection();
        }
    }
}
