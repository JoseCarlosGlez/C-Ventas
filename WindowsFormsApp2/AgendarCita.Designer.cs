namespace WindowsFormsApp2
{
    partial class AgendarCita
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
            this.txbDiaRegistro = new System.Windows.Forms.TextBox();
            this.lblDiaRegistro = new System.Windows.Forms.Label();
            this.txbHoraRegistro = new System.Windows.Forms.TextBox();
            this.lblHoraRegistro = new System.Windows.Forms.Label();
            this.lblServicio = new System.Windows.Forms.Label();
            this.btnCancelarCita = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCita = new FontAwesome.Sharp.IconButton();
            this.txbDiaCita = new System.Windows.Forms.TextBox();
            this.lblDiaCita = new System.Windows.Forms.Label();
            this.txbHoraCita = new System.Windows.Forms.TextBox();
            this.lblHoraCita = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAgendarCita = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txbDiaRegistro);
            this.panel1.Controls.Add(this.lblDiaRegistro);
            this.panel1.Controls.Add(this.txbHoraRegistro);
            this.panel1.Controls.Add(this.lblHoraRegistro);
            this.panel1.Controls.Add(this.lblServicio);
            this.panel1.Controls.Add(this.btnCancelarCita);
            this.panel1.Controls.Add(this.btnGuardarCita);
            this.panel1.Controls.Add(this.txbDiaCita);
            this.panel1.Controls.Add(this.lblDiaCita);
            this.panel1.Controls.Add(this.txbHoraCita);
            this.panel1.Controls.Add(this.lblHoraCita);
            this.panel1.Controls.Add(this.txbNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblAgendarCita);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 446);
            this.panel1.TabIndex = 0;
            // 
            // txbDiaRegistro
            // 
            this.txbDiaRegistro.Location = new System.Drawing.Point(367, 249);
            this.txbDiaRegistro.Multiline = true;
            this.txbDiaRegistro.Name = "txbDiaRegistro";
            this.txbDiaRegistro.Size = new System.Drawing.Size(68, 23);
            this.txbDiaRegistro.TabIndex = 31;
            // 
            // lblDiaRegistro
            // 
            this.lblDiaRegistro.AutoSize = true;
            this.lblDiaRegistro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiaRegistro.Location = new System.Drawing.Point(248, 247);
            this.lblDiaRegistro.Name = "lblDiaRegistro";
            this.lblDiaRegistro.Size = new System.Drawing.Size(104, 20);
            this.lblDiaRegistro.TabIndex = 30;
            this.lblDiaRegistro.Text = "Día de Registro";
            // 
            // txbHoraRegistro
            // 
            this.txbHoraRegistro.Location = new System.Drawing.Point(143, 249);
            this.txbHoraRegistro.Multiline = true;
            this.txbHoraRegistro.Name = "txbHoraRegistro";
            this.txbHoraRegistro.Size = new System.Drawing.Size(68, 23);
            this.txbHoraRegistro.TabIndex = 29;
            // 
            // lblHoraRegistro
            // 
            this.lblHoraRegistro.AutoSize = true;
            this.lblHoraRegistro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraRegistro.Location = new System.Drawing.Point(24, 247);
            this.lblHoraRegistro.Name = "lblHoraRegistro";
            this.lblHoraRegistro.Size = new System.Drawing.Size(113, 20);
            this.lblHoraRegistro.TabIndex = 28;
            this.lblHoraRegistro.Text = "Hora de Registro";
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServicio.Location = new System.Drawing.Point(375, 74);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(60, 20);
            this.lblServicio.TabIndex = 26;
            this.lblServicio.Text = "Servicio";
            // 
            // btnCancelarCita
            // 
            this.btnCancelarCita.FlatAppearance.BorderSize = 0;
            this.btnCancelarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCita.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancelarCita.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCita.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelarCita.IconColor = System.Drawing.Color.Black;
            this.btnCancelarCita.IconSize = 32;
            this.btnCancelarCita.Location = new System.Drawing.Point(367, 332);
            this.btnCancelarCita.Name = "btnCancelarCita";
            this.btnCancelarCita.Rotation = 0D;
            this.btnCancelarCita.Size = new System.Drawing.Size(142, 42);
            this.btnCancelarCita.TabIndex = 25;
            this.btnCancelarCita.Text = "Cancelar";
            this.btnCancelarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCita.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCita
            // 
            this.btnGuardarCita.FlatAppearance.BorderSize = 0;
            this.btnGuardarCita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnGuardarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCita.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardarCita.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCita.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarCita.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCita.IconSize = 32;
            this.btnGuardarCita.Location = new System.Drawing.Point(113, 332);
            this.btnGuardarCita.Name = "btnGuardarCita";
            this.btnGuardarCita.Rotation = 0D;
            this.btnGuardarCita.Size = new System.Drawing.Size(204, 42);
            this.btnGuardarCita.TabIndex = 24;
            this.btnGuardarCita.Text = "Guardar Cita";
            this.btnGuardarCita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCita.UseVisualStyleBackColor = true;
            // 
            // txbDiaCita
            // 
            this.txbDiaCita.Location = new System.Drawing.Point(446, 187);
            this.txbDiaCita.Multiline = true;
            this.txbDiaCita.Name = "txbDiaCita";
            this.txbDiaCita.Size = new System.Drawing.Size(76, 23);
            this.txbDiaCita.TabIndex = 23;
            this.txbDiaCita.TextChanged += new System.EventHandler(this.txbCorreo_TextChanged);
            // 
            // lblDiaCita
            // 
            this.lblDiaCita.AutoSize = true;
            this.lblDiaCita.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaCita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiaCita.Location = new System.Drawing.Point(295, 190);
            this.lblDiaCita.Name = "lblDiaCita";
            this.lblDiaCita.Size = new System.Drawing.Size(140, 20);
            this.lblDiaCita.TabIndex = 22;
            this.lblDiaCita.Text = "Ingrese día de la Cita";
            // 
            // txbHoraCita
            // 
            this.txbHoraCita.Location = new System.Drawing.Point(191, 187);
            this.txbHoraCita.Multiline = true;
            this.txbHoraCita.Name = "txbHoraCita";
            this.txbHoraCita.Size = new System.Drawing.Size(68, 23);
            this.txbHoraCita.TabIndex = 21;
            // 
            // lblHoraCita
            // 
            this.lblHoraCita.AutoSize = true;
            this.lblHoraCita.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraCita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraCita.Location = new System.Drawing.Point(24, 190);
            this.lblHoraCita.Name = "lblHoraCita";
            this.lblHoraCita.Size = new System.Drawing.Size(150, 20);
            this.lblHoraCita.TabIndex = 20;
            this.lblHoraCita.Text = "Ingrese Hora de la Cita\r\n";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(220, 129);
            this.txbNombre.Multiline = true;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(413, 23);
            this.txbNombre.TabIndex = 19;
            this.txbNombre.TextChanged += new System.EventHandler(this.txbNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(24, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(178, 20);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Ingrese Nombre del Cliente";
            // 
            // lblAgendarCita
            // 
            this.lblAgendarCita.AutoSize = true;
            this.lblAgendarCita.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendarCita.Location = new System.Drawing.Point(238, 19);
            this.lblAgendarCita.Name = "lblAgendarCita";
            this.lblAgendarCita.Size = new System.Drawing.Size(155, 23);
            this.lblAgendarCita.TabIndex = 0;
            this.lblAgendarCita.Text = "Agenda una Cita";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Corte de cabello",
            "Corte de cabello y barba",
            "Perfilación ",
            "Perfilacion de Cejas"});
            this.comboBox1.Location = new System.Drawing.Point(456, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 32;
            // 
            // AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 447);
            this.Controls.Add(this.panel1);
            this.Name = "AgendarCita";
            this.Text = "AgendarCita";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAgendarCita;
        private FontAwesome.Sharp.IconButton btnCancelarCita;
        private FontAwesome.Sharp.IconButton btnGuardarCita;
        private System.Windows.Forms.TextBox txbDiaCita;
        private System.Windows.Forms.Label lblDiaCita;
        private System.Windows.Forms.TextBox txbHoraCita;
        private System.Windows.Forms.Label lblHoraCita;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TextBox txbDiaRegistro;
        private System.Windows.Forms.Label lblDiaRegistro;
        private System.Windows.Forms.TextBox txbHoraRegistro;
        private System.Windows.Forms.Label lblHoraRegistro;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}