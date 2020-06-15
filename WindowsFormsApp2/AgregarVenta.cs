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


namespace WindowsFormsApp2
{
    public partial class AgregarVenta : Form
    {

        DataBase db;


        public AgregarVenta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarVenta_Load(object sender, EventArgs e)
        {
            db = new DataBase();
            
        }
    }
}
