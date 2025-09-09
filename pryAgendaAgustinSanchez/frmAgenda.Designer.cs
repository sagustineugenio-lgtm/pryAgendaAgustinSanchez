namespace pryAgendaAgustinSanchez
{
    partial class frmAgenda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.txtContactos = new System.Windows.Forms.TextBox();
            this.lblContactos = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.txtNumero = new System.Windows.Forms.MaskedTextBox();
            this.lblCantidadC = new System.Windows.Forms.Label();
            this.lblFyH = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtContactos
            // 
            this.txtContactos.Location = new System.Drawing.Point(145, 98);
            this.txtContactos.Name = "txtContactos";
            this.txtContactos.Size = new System.Drawing.Size(100, 20);
            this.txtContactos.TabIndex = 0;
            this.txtContactos.TextChanged += new System.EventHandler(this.txtContactos_TextChanged);
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            this.lblContactos.Location = new System.Drawing.Point(23, 101);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(55, 13);
            this.lblContactos.TabIndex = 2;
            this.lblContactos.Text = "Contactos";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(23, 156);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero";
            this.lblNumero.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(145, 214);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 34);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(26, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(26, 293);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(219, 82);
            this.lstItems.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(145, 153);
            this.txtNumero.Mask = "(999)000-0000";
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.MaskChanged += new System.EventHandler(this.txtNumero_MaskChanged);
            this.txtNumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // lblCantidadC
            // 
            this.lblCantidadC.AutoSize = true;
            this.lblCantidadC.Location = new System.Drawing.Point(23, 387);
            this.lblCantidadC.Name = "lblCantidadC";
            this.lblCantidadC.Size = new System.Drawing.Size(115, 13);
            this.lblCantidadC.TabIndex = 5;
            this.lblCantidadC.Text = "Cantidad de Contactos";
            // 
            // lblFyH
            // 
            this.lblFyH.AutoSize = true;
            this.lblFyH.Location = new System.Drawing.Point(23, 453);
            this.lblFyH.Name = "lblFyH";
            this.lblFyH.Size = new System.Drawing.Size(71, 13);
            this.lblFyH.TabIndex = 6;
            this.lblFyH.Text = "Fecha y Hora";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(26, 413);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(23, 490);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Agenda de Contactos";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblFyH);
            this.Controls.Add(this.lblCantidadC);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblContactos);
            this.Controls.Add(this.txtContactos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestion de Agenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContactos;
        private System.Windows.Forms.Label lblContactos;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.MaskedTextBox txtNumero;
        private System.Windows.Forms.Label lblCantidadC;
        private System.Windows.Forms.Label lblFyH;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
    }
}

