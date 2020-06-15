namespace WindowsFormsApp2
{
    partial class ActualizarCliente
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
            this.btnGuardarCte = new FontAwesome.Sharp.IconButton();
            this.txbCorreoCte = new System.Windows.Forms.TextBox();
            this.lblCorreoCte = new System.Windows.Forms.Label();
            this.txbTelefonoCte = new System.Windows.Forms.TextBox();
            this.lblTelefonoCte = new System.Windows.Forms.Label();
            this.txbNombreCte = new System.Windows.Forms.TextBox();
            this.lblNombreCte = new System.Windows.Forms.Label();
            this.txbRFC = new System.Windows.Forms.TextBox();
            this.lblRFC = new System.Windows.Forms.Label();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btnCancelarCte);
            this.panel1.Controls.Add(this.btnGuardarCte);
            this.panel1.Controls.Add(this.txbCorreoCte);
            this.panel1.Controls.Add(this.lblCorreoCte);
            this.panel1.Controls.Add(this.txbTelefonoCte);
            this.panel1.Controls.Add(this.lblTelefonoCte);
            this.panel1.Controls.Add(this.txbNombreCte);
            this.panel1.Controls.Add(this.lblNombreCte);
            this.panel1.Controls.Add(this.txbRFC);
            this.panel1.Controls.Add(this.lblRFC);
            this.panel1.Controls.Add(this.lblAgregar);
            this.panel1.Location = new System.Drawing.Point(1, 0);
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
            this.btnCancelarCte.Location = new System.Drawing.Point(357, 330);
            this.btnCancelarCte.Name = "btnCancelarCte";
            this.btnCancelarCte.Rotation = 0D;
            this.btnCancelarCte.Size = new System.Drawing.Size(142, 42);
            this.btnCancelarCte.TabIndex = 40;
            this.btnCancelarCte.Text = "Cancelar";
            this.btnCancelarCte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarCte.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCte
            // 
            this.btnGuardarCte.FlatAppearance.BorderSize = 0;
            this.btnGuardarCte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnGuardarCte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCte.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGuardarCte.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCte.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnGuardarCte.IconColor = System.Drawing.Color.Black;
            this.btnGuardarCte.IconSize = 32;
            this.btnGuardarCte.Location = new System.Drawing.Point(88, 330);
            this.btnGuardarCte.Name = "btnGuardarCte";
            this.btnGuardarCte.Rotation = 0D;
            this.btnGuardarCte.Size = new System.Drawing.Size(204, 42);
            this.btnGuardarCte.TabIndex = 39;
            this.btnGuardarCte.Text = "Guardar Cliente";
            this.btnGuardarCte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCte.UseVisualStyleBackColor = true;
            // 
            // txbCorreoCte
            // 
            this.txbCorreoCte.Location = new System.Drawing.Point(253, 262);
            this.txbCorreoCte.Multiline = true;
            this.txbCorreoCte.Name = "txbCorreoCte";
            this.txbCorreoCte.Size = new System.Drawing.Size(168, 23);
            this.txbCorreoCte.TabIndex = 38;
            // 
            // lblCorreoCte
            // 
            this.lblCorreoCte.AutoSize = true;
            this.lblCorreoCte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoCte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCorreoCte.Location = new System.Drawing.Point(57, 265);
            this.lblCorreoCte.Name = "lblCorreoCte";
            this.lblCorreoCte.Size = new System.Drawing.Size(171, 20);
            this.lblCorreoCte.TabIndex = 37;
            this.lblCorreoCte.Text = "Ingrese Correo del Cliente";
            // 
            // txbTelefonoCte
            // 
            this.txbTelefonoCte.Location = new System.Drawing.Point(263, 205);
            this.txbTelefonoCte.Multiline = true;
            this.txbTelefonoCte.Name = "txbTelefonoCte";
            this.txbTelefonoCte.Size = new System.Drawing.Size(211, 23);
            this.txbTelefonoCte.TabIndex = 36;
            // 
            // lblTelefonoCte
            // 
            this.lblTelefonoCte.AutoSize = true;
            this.lblTelefonoCte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefonoCte.Location = new System.Drawing.Point(57, 208);
            this.lblTelefonoCte.Name = "lblTelefonoCte";
            this.lblTelefonoCte.Size = new System.Drawing.Size(183, 20);
            this.lblTelefonoCte.TabIndex = 35;
            this.lblTelefonoCte.Text = "Ingrese Telefono del Cliente";
            // 
            // txbNombreCte
            // 
            this.txbNombreCte.Location = new System.Drawing.Point(263, 155);
            this.txbNombreCte.Multiline = true;
            this.txbNombreCte.Name = "txbNombreCte";
            this.txbNombreCte.Size = new System.Drawing.Size(359, 23);
            this.txbNombreCte.TabIndex = 34;
            // 
            // lblNombreCte
            // 
            this.lblNombreCte.AutoSize = true;
            this.lblNombreCte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreCte.Location = new System.Drawing.Point(57, 158);
            this.lblNombreCte.Name = "lblNombreCte";
            this.lblNombreCte.Size = new System.Drawing.Size(178, 20);
            this.lblNombreCte.TabIndex = 33;
            this.lblNombreCte.Text = "Ingrese Nombre del Cliente";
            // 
            // txbRFC
            // 
            this.txbRFC.Location = new System.Drawing.Point(215, 110);
            this.txbRFC.Multiline = true;
            this.txbRFC.Name = "txbRFC";
            this.txbRFC.Size = new System.Drawing.Size(153, 23);
            this.txbRFC.TabIndex = 32;
            // 
            // lblRFC
            // 
            this.lblRFC.AutoSize = true;
            this.lblRFC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRFC.Location = new System.Drawing.Point(57, 113);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(155, 20);
            this.lblRFC.TabIndex = 31;
            this.lblRFC.Text = "Ingrese RFC del Cliente";
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(211, 22);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(186, 23);
            this.lblAgregar.TabIndex = 1;
            this.lblAgregar.Text = "Actualiza un Cliente";
            // 
            // ActualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 447);
            this.Controls.Add(this.panel1);
            this.Name = "ActualizarCliente";
            this.Text = "ActualizarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnCancelarCte;
        private FontAwesome.Sharp.IconButton btnGuardarCte;
        private System.Windows.Forms.TextBox txbCorreoCte;
        private System.Windows.Forms.Label lblCorreoCte;
        private System.Windows.Forms.TextBox txbTelefonoCte;
        private System.Windows.Forms.Label lblTelefonoCte;
        private System.Windows.Forms.TextBox txbNombreCte;
        private System.Windows.Forms.Label lblNombreCte;
        private System.Windows.Forms.TextBox txbRFC;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label lblAgregar;
    }
}