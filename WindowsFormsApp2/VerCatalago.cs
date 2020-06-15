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
using WindowsFormsApp2.Catalogo;

namespace WindowsFormsApp2
{
    public partial class VerCatalago : Form
    {
        MySqlDataReader reader;
        List<ClassCatalogo> catalogo = new List<ClassCatalogo>();
        DataBase DB;
        public VerCatalago()
        {
            InitializeComponent();
        }

        private void VerCatalago_Load(object sender, EventArgs e)
        {
            ObtenerCatalogo();
        }

        public void ObtenerCatalogo()
        {
            DB = new DataBase();
            string query = " select * from catalogo";
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
                catalogo.Add(
                    new ClassCatalogo
                    {
                        Codigo = Convert.ToInt16(reader["Codigo"]),
                        Nombre = Convert.ToString(reader["Nombre"]),
                        Descripcion = Convert.ToString(reader["Descripcion"]),
                        Precio = Convert.ToString(reader["Precio"]),
                        Tipo = Convert.ToString(reader["Tipo"]),

                    }
                    );
            }
            reader.Close();
            dataGridView1.DataSource = catalogo;
            DB.closeConnection();
        }


    }
}
