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

namespace WindowsFormsApp2
{
    public partial class AgregarCliente : Form
    {
        DataBase db;

       
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void txbAgendarID_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGuardarCte_Click(object sender, EventArgs e)

        {
            string RFCCliente = txbRFC.Text;
            string NombreCliente = txbNombreCte.Text;
            string TelefonoCliente = txbTelefonoCte.Text;
            string CorreoCliente = txbCorreoCte.Text;

            string query = "INSERT INTO `cliente`(`IdCliente`, `RfcCliente`, `NombreCliente`, `TelCliente`, `CorreoCliente`) VALUES (null,'" + RFCCliente + "','" + NombreCliente + "','" + TelefonoCliente + "','" + CorreoCliente + "')";

            db = new DataBase();
           bool resultado= db.EjecutarQuery(query);
            if (resultado == true)
            {
                MessageBox.Show("Cliente guardado exitosamente");
            }
            else
            {
                MessageBox.Show("Hubo un problema en el registro");
            }
            db.closeConnection();

        }

        private void btnCancelarCte_Click(object sender, EventArgs e)
        {
            txbRFC.Text = "";
            txbNombreCte.Text = "";
            txbTelefonoCte.Text = "";
            txbCorreoCte.Text = "";
        }
    }
}
