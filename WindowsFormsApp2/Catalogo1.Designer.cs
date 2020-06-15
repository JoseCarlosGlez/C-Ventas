namespace WindowsFormsApp2
{
    partial class Catalogo1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comTipo = new System.Windows.Forms.ComboBox();
            this.btnCancelarP = new FontAwesome.Sharp.IconButton();
            this.btnGuardarP = new FontAwesome.Sharp.IconButton();
            this.txbPrecioP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescripcionP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombreP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.comTipo);
            this.panel1.Controls.Add(this.btnCancelarP);
            this.panel1.Controls.Add(this.btnGuardarP);
            this.panel1.Controls.Add(this.txbPrecioP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbDescripcionP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbNombreP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCatalogo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 446);
            this.panel1.TabIndex = 0;
            // 
            // comTipo
            // 
            this.comTipo.FormattingEnabled = true;
            this.comTipo.Items.AddRange(new object[] {
            "Servicio",
            "Producto"});
            this.comTipo.Location = new System.Drawing.Point(446, 86);
            this.comTipo.Name = "comTipo";
            this.comTipo.Size = new System.Drawing.Size(121, 21);
            this.comTipo.TabIndex = 43;
            // 
            // btnCancelarP
            // 
            this.btnCancelarP.FlatAppearance.BorderSize = 0;
            this.btnCancelarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarP.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancelarP.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarP.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelarP.IconColor = System.Drawing.Color.Black;
            this.btnCancelarP.IconSize = 32;
            this.btnCancelarP.Location = new System.Drawing.Point(354, 350);
            this.btnCancelarP.Name = "btnCancelarP";
            this.btnCancelarP.Rotation = 0D;
            this.btnCancelarP.Size = new System.Drawing.Size(142, 42);
            this.btnCancelarP.TabIndex = 42;
            this.btnCancelarP.Text = "Cancelar";
            this.btnCancelarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarP.UseVisualStyleBackColor = true;
            this.btnCancelarP.Click += new System.EventHandler(this.btnCancelarP_Click);
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.FlatAppearance.BorderSize = 0;
            this.btnGuardarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarP.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardarP.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarP.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarP.IconColor = System.Drawing.Color.Black;
            this.btnGuardarP.IconSize = 32;
            this.btnGuardarP.Location = new System.Drawing.Point(110, 350);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Rotation = 0D;
            this.btnGuardarP.Size = new System.Drawing.Size(213, 42);
            this.btnGuardarP.TabIndex = 41;
            this.btnGuardarP.Text = "Guardar Producto";
            this.btnGuardarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // txbPrecioP
            // 
            this.txbPrecioP.Location = new System.Drawing.Point(214, 269);
            this.txbPrecioP.Multiline = true;
            this.txbPrecioP.Name = "txbPrecioP";
            this.txbPrecioP.Size = new System.Drawing.Size(90, 33);
            this.txbPrecioP.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio de su producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo";
            // 
            // txbDescripcionP
            // 
            this.txbDescripcionP.Location = new System.Drawing.Point(241, 171);
            this.txbDescripcionP.Multiline = true;
            this.txbDescripcionP.Name = "txbDescripcionP";
            this.txbDescripcionP.Size = new System.Drawing.Size(358, 57);
            this.txbDescripcionP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción de su producto";
            // 
            // txbNombreP
            // 
            this.txbNombreP.Location = new System.Drawing.Point(214, 128);
            this.txbNombreP.Multiline = true;
            this.txbNombreP.Name = "txbNombreP";
            this.txbNombreP.Size = new System.Drawing.Size(430, 20);
            this.txbNombreP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de su producto";
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.Location = new System.Drawing.Point(210, 38);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(190, 23);
            this.lblCatalogo.TabIndex = 0;
            this.lblCatalogo.Text = "Ingrese un Producto";
            // 
            // Catalogo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 446);
            this.Controls.Add(this.panel1);
            this.Name = "Catalogo1";
            this.Text = "Catalogo1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCatalogo;
        private System.Windows.Forms.TextBox txbPrecioP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDescripcionP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombreP;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCancelarP;
        private FontAwesome.Sharp.IconButton btnGuardarP;
        private System.Windows.Forms.ComboBox comTipo;
    }
}