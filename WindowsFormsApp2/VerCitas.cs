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
using WindowsFormsApp2.Citas;

namespace WindowsFormsApp2
{
    public partial class VerCitas : Form
    {
        MySqlDataReader reader;
        List<ClassCitas> citas = new List<ClassCitas>();
        DataBase DB;
        public VerCitas()
        {
            InitializeComponent();
        }

        private void VerCitas_Load(object sender, EventArgs e)
        {
            ObtenerCitas();
        }
        public void ObtenerCitas()
        {
            DB = new DataBase();
            string query = " select * from cita";
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
                citas.Add(
                    new ClassCitas
                    {
                        IdCita = Convert.ToInt16(reader["IdCita"]),
                        HoraCita = Convert.ToString(reader["HoraCita"]),
                        DiaCita = Convert.ToString(reader["DiaCita"]),
                        HoraRegistro = Convert.ToString(reader["HoraRegistro"]),
                        DiaRegistro = Convert.ToString(reader["DiaRegistro"]),

                    }
                    );
            }
            reader.Close();
            dataGridView1.DataSource = citas;
            DB.closeConnection();
        }
    }



}

