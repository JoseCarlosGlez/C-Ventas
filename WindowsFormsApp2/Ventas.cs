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
using WindowsFormsApp2.VentasClase;

namespace WindowsFormsApp2
{
    public partial class Ventas : Form
    {
        MySqlDataReader reader;
        List<ClassVentas> ventas = new List<ClassVentas>();
        DataBase DB;
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            ObtenerVentas();
        }

        public void ObtenerVentas()
        {
            DB = new DataBase();
            string query = " select * from venta";
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
                ventas.Add(
                    new ClassVentas
                    {
                        Folio = Convert.ToInt16(reader["Folio"]),
                        Concepto = Convert.ToString(reader["Concepto"]),
                        FechaVenta = Convert.ToString(reader["FechaVenta"]),
                        SubTotal = Convert.ToDouble(reader["SubTotal"]),
                        Total = Convert.ToDouble(reader["Total"]),

                    }
                    );
            }
            reader.Close();
            dataGridView1.DataSource = ventas;
            DB.closeConnection();
        }


    }
}
