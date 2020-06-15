namespace WindowsFormsApp2
{
    partial class Actualizar_Catalago
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
            this.btnCancelarCte = new FontAwesome.Sharp.IconButton();
            this.btnGuardarProducto = new FontAwesome.Sharp.IconButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIngresarP = new System.Windows.Forms.Label();
            this.lblCatalogo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btnCancelarCte);
            this.panel1.Controls.Add(this.btnGuardarProducto);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblIngresarP);
            this.panel1.Controls.Add(this.lblCatalogo);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 446);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelarCte
            // 
            this.btnCancelarCte.FlatAppearance.BorderSize = 0;
            this.btnCancelarCte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelarCte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCte.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancelarCte.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCte.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelarCte.IconColor = System.Drawing.Color.Black;
            this.btnCancelarCte.IconSize = 32;
            this.btnCancelarCte.Location = new System.Drawing.Point(354, 350);
            this.btnCancelarCte.Name = "btnCancelarCte";
            this.btnCancelarCte.Rotation = 0D;
            this.btnCancelarCte.Size = new System.Drawing.Size(142, 42);
            this.btnCancelarCte.TabIndex = 42;
            this.btnCancelarCte.Text = "Cancelar";
            this.btnCancelarCte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCte.UseVisualStyleBackColor = true;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarProducto.IconColor = System.Drawing.Color.Black;
            this.btnGuardarProducto.IconSize = 32;
            this.btnGuardarProducto.Location = new System.Drawing.Point(165, 350);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Rotation = 0D;
            this.btnGuardarProducto.Size = new System.Drawing.Size(164, 42);
            this.btnGuardarProducto.TabIndex = 41;
            this.btnGuardarProducto.Text = "Editar";
            this.btnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(214, 269);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 33);
            this.textBox4.TabIndex = 10;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(437, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 17);
            this.listBox1.TabIndex = 8;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(245, 171);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(354, 82);
            this.textBox3.TabIndex = 6;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 128);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(430, 20);
            this.textBox2.TabIndex = 4;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblIngresarP
            // 
            this.lblIngresarP.AutoSize = true;
            this.lblIngresarP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarP.Location = new System.Drawing.Point(54, 86);
            this.lblIngresarP.Name = "lblIngresarP";
            this.lblIngresarP.Size = new System.Drawing.Size(152, 20);
            this.lblIngresarP.TabIndex = 1;
            this.lblIngresarP.Text = "Código de su producto";
            // 
            // lblCatalogo
            // 
            this.lblCatalogo.AutoSize = true;
            this.lblCatalogo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatalogo.Location = new System.Drawing.Point(210, 38);
            this.lblCatalogo.Name = "lblCatalogo";
            this.lblCatalogo.Size = new System.Drawing.Size(205, 23);
            this.lblCatalogo.TabIndex = 0;
            this.lblCatalogo.Text = "Actualiza un Producto";
            // 
            // Actualizar_Catalago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 448);
            this.Controls.Add(this.panel1);
            this.Name = "Actualizar_Catalago";
            this.Text = "Actualizar_Catalago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelarCte;
        private FontAwesome.Sharp.IconButton btnGuardarProducto;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIngresarP;
        private System.Windows.Forms.Label lblCatalogo;
    }
}