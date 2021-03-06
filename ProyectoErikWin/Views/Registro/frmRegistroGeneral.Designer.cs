﻿namespace ProyectoErikWin.Views
{
    partial class frmRegistroGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroGeneral));
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtNumeroMac = new System.Windows.Forms.TextBox();
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rsComputo = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.pnlIzquierdo.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.Color.Transparent;
            this.pnlIzquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlIzquierdo.BackgroundImage")));
            this.pnlIzquierdo.Controls.Add(this.lblEmail);
            this.pnlIzquierdo.Controls.Add(this.btnSalir);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(159, 406);
            this.pnlIzquierdo.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(3, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 15);
            this.lblEmail.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(10, 364);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 31);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.cbMarca);
            this.pnlContenedor.Controls.Add(this.btnRegistrar);
            this.pnlContenedor.Controls.Add(this.txtNombreComercial);
            this.pnlContenedor.Controls.Add(this.txtDisplay);
            this.pnlContenedor.Controls.Add(this.txtNumeroMac);
            this.pnlContenedor.Controls.Add(this.txtProcesador);
            this.pnlContenedor.Controls.Add(this.txtColor);
            this.pnlContenedor.Controls.Add(this.txtNumSerie);
            this.pnlContenedor.Controls.Add(this.txtObservacion);
            this.pnlContenedor.Controls.Add(this.txtDescripcion);
            this.pnlContenedor.Controls.Add(this.label2);
            this.pnlContenedor.Controls.Add(this.shapeContainer1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(159, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(468, 406);
            this.pnlContenedor.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Location = new System.Drawing.Point(346, 361);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(104, 31);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.ForeColor = System.Drawing.Color.Black;
            this.txtNombreComercial.Location = new System.Drawing.Point(241, 207);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(209, 30);
            this.txtNombreComercial.TabIndex = 13;
            this.txtNombreComercial.Text = "Nombre Comercial";
            this.txtNombreComercial.Enter += new System.EventHandler(this.txtNombreComercial_Enter);
            this.txtNombreComercial.Leave += new System.EventHandler(this.txtNombreComercial_Leave);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.Black;
            this.txtDisplay.Location = new System.Drawing.Point(24, 207);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(201, 30);
            this.txtDisplay.TabIndex = 12;
            this.txtDisplay.Text = "Display";
            this.txtDisplay.Enter += new System.EventHandler(this.txtDisplay_Enter);
            this.txtDisplay.Leave += new System.EventHandler(this.txtDisplay_Leave);
            // 
            // txtNumeroMac
            // 
            this.txtNumeroMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroMac.ForeColor = System.Drawing.Color.Black;
            this.txtNumeroMac.Location = new System.Drawing.Point(241, 168);
            this.txtNumeroMac.Name = "txtNumeroMac";
            this.txtNumeroMac.Size = new System.Drawing.Size(209, 30);
            this.txtNumeroMac.TabIndex = 11;
            this.txtNumeroMac.Text = "Numero Mac";
            this.txtNumeroMac.Enter += new System.EventHandler(this.txtNumeroMac_Enter);
            this.txtNumeroMac.Leave += new System.EventHandler(this.txtNumeroMac_Leave);
            // 
            // txtProcesador
            // 
            this.txtProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcesador.ForeColor = System.Drawing.Color.Black;
            this.txtProcesador.Location = new System.Drawing.Point(24, 168);
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(201, 30);
            this.txtProcesador.TabIndex = 10;
            this.txtProcesador.Text = "Procesador";
            this.txtProcesador.Enter += new System.EventHandler(this.txtProcesador_Enter);
            this.txtProcesador.Leave += new System.EventHandler(this.txtProcesador_Leave);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.ForeColor = System.Drawing.Color.Black;
            this.txtColor.Location = new System.Drawing.Point(241, 126);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(209, 30);
            this.txtColor.TabIndex = 9;
            this.txtColor.Text = "Color";
            this.txtColor.Enter += new System.EventHandler(this.txtColor_Enter);
            this.txtColor.Leave += new System.EventHandler(this.txtColor_Leave);
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.ForeColor = System.Drawing.Color.Black;
            this.txtNumSerie.Location = new System.Drawing.Point(24, 126);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(201, 30);
            this.txtNumSerie.TabIndex = 8;
            this.txtNumSerie.Text = "Numero de Serie";
            this.txtNumSerie.Enter += new System.EventHandler(this.txtNumSerie_Enter);
            this.txtNumSerie.Leave += new System.EventHandler(this.txtNumSerie_Leave);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.Black;
            this.txtObservacion.Location = new System.Drawing.Point(241, 84);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(209, 30);
            this.txtObservacion.TabIndex = 7;
            this.txtObservacion.Text = "Observaciones";
            this.txtObservacion.Enter += new System.EventHandler(this.txtObservacion_Enter);
            this.txtObservacion.Leave += new System.EventHandler(this.txtObservacion_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(23, 84);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(201, 30);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Text = "Descripción";
            this.txtDescripcion.Enter += new System.EventHandler(this.txtDescripcion_Enter);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(60)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Computo";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rsComputo});
            this.shapeContainer1.Size = new System.Drawing.Size(468, 406);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rsComputo
            // 
            this.rsComputo.BackColor = System.Drawing.Color.Silver;
            this.rsComputo.BorderColor = System.Drawing.Color.Silver;
            this.rsComputo.Enabled = false;
            this.rsComputo.FillGradientColor = System.Drawing.Color.DimGray;
            this.rsComputo.Location = new System.Drawing.Point(10, 22);
            this.rsComputo.Name = "rsComputo";
            this.rsComputo.Size = new System.Drawing.Size(451, 372);
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(24, 49);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(200, 21);
            this.cbMarca.TabIndex = 15;
            // 
            // frmRegistroGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 406);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroGeneral";
            this.pnlIzquierdo.ResumeLayout(false);
            this.pnlIzquierdo.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlIzquierdo;
        private System.Windows.Forms.Panel pnlContenedor;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rsComputo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.TextBox txtNombreComercial;
        public System.Windows.Forms.TextBox txtDisplay;
        public System.Windows.Forms.TextBox txtNumeroMac;
        public System.Windows.Forms.TextBox txtProcesador;
        public System.Windows.Forms.TextBox txtColor;
        public System.Windows.Forms.TextBox txtNumSerie;
        public System.Windows.Forms.TextBox txtObservacion;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbMarca;
    }
}