namespace WindowsFormsApp2
{
    partial class ActualizarCita
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
            this.pActualizarCita = new System.Windows.Forms.Panel();
            this.txbDiaActualizacion = new System.Windows.Forms.TextBox();
            this.lblDiaActualizacion = new System.Windows.Forms.Label();
            this.txbHoraActualizacion = new System.Windows.Forms.TextBox();
            this.lblHoraActualizacion = new System.Windows.Forms.Label();
            this.txbActualizarServicio = new System.Windows.Forms.ListBox();
            this.lblActualizarServicio = new System.Windows.Forms.Label();
            this.txbDiaNuevoCita = new System.Windows.Forms.TextBox();
            this.lblDiaNuevoCita = new System.Windows.Forms.Label();
            this.txbHoraNuevaCita = new System.Windows.Forms.TextBox();
            this.lblHoraNuevaCita = new System.Windows.Forms.Label();
            this.txbActualizarNombre = new System.Windows.Forms.TextBox();
            this.lblActualizarNombre = new System.Windows.Forms.Label();
            this.btnCancelarActualizacion = new FontAwesome.Sharp.IconButton();
            this.btnGuardarActualizacion = new FontAwesome.Sharp.IconButton();
            this.lblActualizarCita = new System.Windows.Forms.Label();
            this.pActualizarCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // pActualizarCita
            // 
            this.pActualizarCita.BackColor = System.Drawing.Color.LightSlateGray;
            this.pActualizarCita.Controls.Add(this.txbDiaActualizacion);
            this.pActualizarCita.Controls.Add(this.lblDiaActualizacion);
            this.pActualizarCita.Controls.Add(this.txbHoraActualizacion);
            this.pActualizarCita.Controls.Add(this.lblHoraActualizacion);
            this.pActualizarCita.Controls.Add(this.txbActualizarServicio);
            this.pActualizarCita.Controls.Add(this.lblActualizarServicio);
            this.pActualizarCita.Controls.Add(this.txbDiaNuevoCita);
            this.pActualizarCita.Controls.Add(this.lblDiaNuevoCita);
            this.pActualizarCita.Controls.Add(this.txbHoraNuevaCita);
            this.pActualizarCita.Controls.Add(this.lblHoraNuevaCita);
            this.pActualizarCita.Controls.Add(this.txbActualizarNombre);
            this.pActualizarCita.Controls.Add(this.lblActualizarNombre);
            this.pActualizarCita.Controls.Add(this.btnCancelarActualizacion);
            this.pActualizarCita.Controls.Add(this.btnGuardarActualizacion);
            this.pActualizarCita.Controls.Add(this.lblActualizarCita);
            this.pActualizarCita.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pActualizarCita.Location = new System.Drawing.Point(2, 1);
            this.pActualizarCita.Name = "pActualizarCita";
            this.pActualizarCita.Size = new System.Drawing.Size(655, 446);
            this.pActualizarCita.TabIndex = 0;
            // 
            // txbDiaActualizacion
            // 
            this.txbDiaActualizacion.Location = new System.Drawing.Point(467, 245);
            this.txbDiaActualizacion.Multiline = true;
            this.txbDiaActualizacion.Name = "txbDiaActualizacion";
            this.txbDiaActualizacion.Size = new System.Drawing.Size(77, 23);
            this.txbDiaActualizacion.TabIndex = 47;
            // 
            // lblDiaActualizacion
            // 
            this.lblDiaActualizacion.AutoSize = true;
            this.lblDiaActualizacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaActualizacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiaActualizacion.Location = new System.Drawing.Point(294, 248);
            this.lblDiaActualizacion.Name = "lblDiaActualizacion";
            this.lblDiaActualizacion.Size = new System.Drawing.Size(150, 20);
            this.lblDiaActualizacion.TabIndex = 46;
            this.lblDiaActualizacion.Text = "Día de la Actualizacion";
            // 
            // txbHoraActualizacion
            // 
            this.txbHoraActualizacion.Location = new System.Drawing.Point(190, 245);
            this.txbHoraActualizacion.Multiline = true;
            this.txbHoraActualizacion.Name = "txbHoraActualizacion";
            this.txbHoraActualizacion.Size = new System.Drawing.Size(68, 23);
            this.txbHoraActualizacion.TabIndex = 45;
            // 
            // lblHoraActualizacion
            // 
            this.lblHoraActualizacion.AutoSize = true;
            this.lblHoraActualizacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActualizacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraActualizacion.Location = new System.Drawing.Point(23, 248);
            this.lblHoraActualizacion.Name = "lblHoraActualizacion";
            this.lblHoraActualizacion.Size = new System.Drawing.Size(159, 20);
            this.lblHoraActualizacion.TabIndex = 44;
            this.lblHoraActualizacion.Text = "Hora de la Actualizacion";
            // 
            // txbActualizarServicio
            // 
            this.txbActualizarServicio.FormattingEnabled = true;
            this.txbActualizarServicio.ItemHeight = 20;
            this.txbActualizarServicio.Location = new System.Drawing.Point(406, 65);
            this.txbActualizarServicio.Name = "txbActualizarServicio";
            this.txbActualizarServicio.Size = new System.Drawing.Size(115, 24);
            this.txbActualizarServicio.TabIndex = 43;
            // 
            // lblActualizarServicio
            // 
            this.lblActualizarServicio.AutoSize = true;
            this.lblActualizarServicio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActualizarServicio.Location = new System.Drawing.Point(329, 69);
            this.lblActualizarServicio.Name = "lblActualizarServicio";
            this.lblActualizarServicio.Size = new System.Drawing.Size(60, 20);
            this.lblActualizarServicio.TabIndex = 42;
            this.lblActualizarServicio.Text = "Servicio";
            // 
            // txbDiaNuevoCita
            // 
            this.txbDiaNuevoCita.Location = new System.Drawing.Point(445, 188);
            this.txbDiaNuevoCita.Multiline = true;
            this.txbDiaNuevoCita.Name = "txbDiaNuevoCita";
            this.txbDiaNuevoCita.Size = new System.Drawing.Size(76, 23);
            this.txbDiaNuevoCita.TabIndex = 39;
            // 
            // lblDiaNuevoCita
            // 
            this.lblDiaNuevoCita.AutoSize = true;
            this.lblDiaNuevoCita.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaNuevoCita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiaNuevoCita.Location = new System.Drawing.Point(294, 191);
            this.lblDiaNuevoCita.Name = "lblDiaNuevoCita";
            this.lblDiaNuevoCita.Size = new System.Drawing.Size(122, 20);
            this.lblDiaNuevoCita.TabIndex = 38;
            this.lblDiaNuevoCita.Text = "Ingrese Nuevo Día";
            // 
            // txbHoraNuevaCita
            // 
            this.txbHoraNuevaCita.Location = new System.Drawing.Point(190, 188);
            this.txbHoraNuevaCita.Multiline = true;
            this.txbHoraNuevaCita.Name = "txbHoraNuevaCita";
            this.txbHoraNuevaCita.Size = new System.Drawing.Size(68, 23);
            this.txbHoraNuevaCita.TabIndex = 37;
            // 
            // lblHoraNuevaCita
            // 
            this.lblHoraNuevaCita.AutoSize = true;
            this.lblHoraNuevaCita.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraNuevaCita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHoraNuevaCita.Location = new System.Drawing.Point(23, 191);
            this.lblHoraNuevaCita.Name = "lblHoraNuevaCita";
            this.lblHoraNuevaCita.Size = new System.Drawing.Size(130, 20);
            this.lblHoraNuevaCita.TabIndex = 36;
            this.lblHoraNuevaCita.Text = "Ingrese Nueva Hora";
            // 
            // txbActualizarNombre
            // 
            this.txbActualizarNombre.Location = new System.Drawing.Point(219, 130);
            this.txbActualizarNombre.Multiline = true;
            this.txbActualizarNombre.Name = "txbActualizarNombre";
            this.txbActualizarNombre.Size = new System.Drawing.Size(413, 23);
            this.txbActualizarNombre.TabIndex = 35;
            // 
            // lblActualizarNombre
            // 
            this.lblActualizarNombre.AutoSize = true;
            this.lblActualizarNombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblActualizarNombre.Location = new System.Drawing.Point(23, 133);
            this.lblActualizarNombre.Name = "lblActualizarNombre";
            this.lblActualizarNombre.Size = new System.Drawing.Size(178, 20);
            this.lblActualizarNombre.TabIndex = 34;
            this.lblActualizarNombre.Text = "Ingrese Nombre del Cliente";
            // 
            // btnCancelarActualizacion
            // 
            this.btnCancelarActualizacion.FlatAppearance.BorderSize = 0;
            this.btnCancelarActualizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelarActualizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarActualizacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCancelarActualizacion.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarActualizacion.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelarActualizacion.IconColor = System.Drawing.Color.Black;
            this.btnCancelarActualizacion.IconSize = 32;
            this.btnCancelarActualizacion.Location = new System.Drawing.Point(358, 329);
            this.btnCancelarActualizacion.Name = "btnCancelarActualizacion";
            this.btnCancelarActualizacion.Rotation = 0D;
            this.btnCancelarActualizacion.Size = new System.Drawing.Size(142, 42);
            this.btnCancelarActualizacion.TabIndex = 15;
            this.btnCancelarActualizacion.Text = "Cancelar";
            this.btnCancelarActualizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarActualizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarActualizacion.UseVisualStyleBackColor = true;
            // 
            // btnGuardarActualizacion
            // 
            this.btnGuardarActualizacion.FlatAppearance.BorderSize = 0;
            this.btnGuardarActualizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnGuardarActualizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarActualizacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardarActualizacion.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarActualizacion.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarActualizacion.IconColor = System.Drawing.Color.Black;
            this.btnGuardarActualizacion.IconSize = 32;
            this.btnGuardarActualizacion.Location = new System.Drawing.Point(101, 329);
            this.btnGuardarActualizacion.Name = "btnGuardarActualizacion";
            this.btnGuardarActualizacion.Rotation = 0D;
            this.btnGuardarActualizacion.Size = new System.Drawing.Size(204, 42);
            this.btnGuardarActualizacion.TabIndex = 14;
            this.btnGuardarActualizacion.Text = "Guardar Cambios";
            this.btnGuardarActualizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarActualizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarActualizacion.UseVisualStyleBackColor = true;
            // 
            // lblActualizarCita
            // 
            this.lblActualizarCita.AutoSize = true;
            this.lblActualizarCita.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarCita.Location = new System.Drawing.Point(202, 23);
            this.lblActualizarCita.Name = "lblActualizarCita";
            this.lblActualizarCita.Size = new System.Drawing.Size(170, 23);
            this.lblActualizarCita.TabIndex = 0;
            this.lblActualizarCita.Text = "Actualiza una Cita";
            // 
            // ActualizarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 437);
            this.Controls.Add(this.pActualizarCita);
            this.Name = "ActualizarCita";
            this.Text = "ActualizarCita";
            this.pActualizarCita.ResumeLayout(false);
            this.pActualizarCita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pActualizarCita;
        private FontAwesome.Sharp.IconButton btnGuardarActualizacion;
        private System.Windows.Forms.Label lblActualizarCita;
        private FontAwesome.Sharp.IconButton btnCancelarActualizacion;
        private System.Windows.Forms.TextBox txbDiaActualizacion;
        private System.Windows.Forms.Label lblDiaActualizacion;
        private System.Windows.Forms.TextBox txbHoraActualizacion;
        private System.Windows.Forms.Label lblHoraActualizacion;
        private System.Windows.Forms.ListBox txbActualizarServicio;
        private System.Windows.Forms.Label lblActualizarServicio;
        private System.Windows.Forms.TextBox txbDiaNuevoCita;
        private System.Windows.Forms.Label lblDiaNuevoCita;
        private System.Windows.Forms.TextBox txbHoraNuevaCita;
        private System.Windows.Forms.Label lblHoraNuevaCita;
        private System.Windows.Forms.TextBox txbActualizarNombre;
        private System.Windows.Forms.Label lblActualizarNombre;
    }
}