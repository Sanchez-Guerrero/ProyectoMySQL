using ProyectoErik.Entidades.Entidades;
using ProyectoErik.Logica.Logicas;
using ProyectoErikWin.Views.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErikWin.Views
{
    public partial class frmRegistroGeneral : Form
    {
        private LogicaComputo _logicaComputo;
        frmLogin frmlogin = new frmLogin();
        public frmRegistroGeneral()
        {
            InitializeComponent();
            _logicaComputo = new LogicaComputo();
            lblEmail.Text = frmlogin.email;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Computo entidadComputo = new Computo
                {
                    descripcion = txtDescripcion.Text,
                    observaciones = txtObservacion.Text,
                    numeroSerie = txtNumSerie.Text,
                    color = txtColor.Text,
                    nombre = txtNombreMarca.Text,
                    descripcionMarca = rtxtDescripcionMarca.Text,
                    procesador = txtProcesador.Text,
                    numeroMac = txtNumeroMac.Text,
                    display = txtDisplay.Text,
                    nombreComercial = txtNombreComercial.Text
                };
                _logicaComputo.InsertarComputoyMarca(entidadComputo);
                MessageBox.Show("Se guardo Correctamente");
                LimpiarCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se guardo correctamente");
            }
        }

        void LimpiarCampos()
        {
            txtDescripcion.Text = txtObservacion.Text = txtNumSerie.Text = txtColor.Text 
                = txtNombreMarca.Text = rtxtDescripcionMarca.Text = txtProcesador.Text 
                = txtNumeroMac.Text = txtDisplay.Text = txtNombreComercial.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas seguro de salir de la aplicación","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                frmlogin.Show();
            }
        }
    }
}
