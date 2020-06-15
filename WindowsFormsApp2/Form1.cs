using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm = null;

        //CONSTRUCTOR//
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            pMenuLateral.Controls.Add(leftBorderBtn);
            //form tamaño//
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //ESTRUCTURA COLORES BOTONES//
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(24, 161, 251);

        }

        //METODO COLORES Y ALINEACIONES ICONO//
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //btnInicio//
                btnHijoInicio.IconChar = currentBtn.IconChar;
                btnHijoInicio.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }



        private void customizeDesing()
        {
            pSubMenuCitas.Visible = false;
            pSubMenuClientes.Visible = false;
            pSubMenuCatalogo.Visible = false;
            pSubMenuVta.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pSubMenuCitas.Visible == true)
                pSubMenuCitas.Visible = false;
            if (pSubMenuClientes.Visible == true)
                pSubMenuClientes.Visible = false;
            if (pSubMenuCatalogo.Visible == true)
                pSubMenuCatalogo.Visible = false;
            if (pSubMenuVta.Visible == true)
                pSubMenuVta.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void btnCitas_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pSubMenuCitas);
            ActivateButton(sender, RGBColors.color1);

        }

        private void btnAgendarCita_Click(object sender, EventArgs e)
        {
            //CODIGO FUNCIONAL//
            hideSubMenu();
            openChildForm(new AgendarCita());
        }

        private void btnActualizarCita_Click(object sender, EventArgs e)
        {
            //CODIGO FUNCIONAL//
            hideSubMenu();
            openChildForm(new ActualizarCita());
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            //CODIGO FUNCIONAL//
            hideSubMenu();
            openChildForm(new VerCitas());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //CODIGO FUNCIONAL//
            showSubMenu(pSubMenuClientes);
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            //CODIGO FUNCIONAL//
            hideSubMenu();
            openChildForm(new AgregarCliente());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //CODIGO FUNCIONAL// btn actualizar//
            hideSubMenu();
            openChildForm(new VerClientes());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //CODIGO FUNCIONAL//
            showSubMenu(pSubMenuVta);
            ActivateButton(sender, RGBColors.color3);
        }
        private void btnAgregarVta_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new AgregarVenta());
        }
        private void btnVerVta_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Ventas());
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            //CODIGO FUNCIONAL//
            showSubMenu (pSubMenuCatalogo);
            ActivateButton(sender, RGBColors.color4);
          
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new Catalogo1());
        }
        private void btnVerCatalogo_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildForm(new VerCatalago());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Reset();
        }


        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            btnHijoInicio.IconChar = IconChar.Home;
            btnHijoInicio.IconColor = Color.Red;
            lblTituloHijo.Text = "Inicio";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pBarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pChildForm.Controls.Add(childForm);
            pChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTituloHijo.Text = childForm.Text;
        }

       
    }
}
