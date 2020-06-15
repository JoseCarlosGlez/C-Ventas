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

    public partial class Catalogo1 : Form
    {
        DataBase db;
        public Catalogo1()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string tipo = comTipo.Text;
            string NombreProducto = txbNombreP.Text;
            string DescripcionProducto = txbDescripcionP.Text;
            double precio = Convert.ToDouble(txbPrecioP.Text);

            string query = "INSERT INTO `catalogo`(`Codigo`, `Nombre`, `Descripcion`, `Precio`, `Tipo`) VALUES (null,'" + NombreProducto + "','" + DescripcionProducto + "','" + precio + "','" + tipo + "')";
            db = new DataBase();
            bool resultado = db.EjecutarQuery(query);
            if (resultado == true)
            {
                MessageBox.Show("Producto agregado correctamente");
            }
            else
            {
                MessageBox.Show("Hubo un problema en el guardado");
            }

            db.closeConnection();
        }

        private void btnCancelarP_Click(object sender, EventArgs e)

        {
            comTipo.Text = "";
            txbNombreP.Text="";
            txbDescripcionP.Text = "";
            txbPrecioP.Text = "";

        }
    }

       
}

