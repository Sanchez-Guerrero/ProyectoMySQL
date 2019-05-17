using MySql.Data.MySqlClient;
using ProyectoErik.Datos.Repositorios;
using ProyectoErik.Entidades.Entidades;
using ProyectoErik.Logica.Logicas;
using ProyectoErikWin.Controller.Login;
using ProyectoErikWin.Controller.RegistroGeneral;
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
        LoginController ctrlLogin = new LoginController();
        public frmRegistroGeneral()
        {
            InitializeComponent();
            lblEmail.Text = ctrlLogin.ema;
            CargarCombo();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroGeneralController ctlregistro = new RegistroGeneralController();
            Computo compu = new Computo();
            compu.descripcion = txtDescripcion.Text;
            compu.observaciones = txtObservacion.Text;
            compu.numeroSerie = txtNumSerie.Text;
            compu.color = txtColor.Text;
            compu.idMarca = cbMarca.SelectedIndex;
            compu.procesador = txtProcesador.Text;
            compu.numeroMac = txtNumeroMac.Text;
            compu.display = txtDisplay.Text;
            compu.nombreComercial = txtNombreComercial.Text;
            ctlregistro.RegistrarFormulario(compu);
            LimpiarCampos();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Estas seguro de salir de la aplicación","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();
                this.Close();
                frm.Show();
            }
        }
        //Las acciones Enter y Leave nos sirven para realizar el placeholder como html.
        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "Descripción")
            {
                txtDescripcion.Text = "";
                txtDescripcion.ForeColor = Color.Black;
            }
        }
        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                txtDescripcion.Text = "Descripción";
                txtDescripcion.ForeColor = Color.Black;
            }
        }
        private void txtObservacion_Enter(object sender, EventArgs e)
        {
            if (txtObservacion.Text == "Observaciones")
            {
                txtObservacion.Text = "";
                txtObservacion.ForeColor = Color.Black;
            }
        }
        private void txtObservacion_Leave(object sender, EventArgs e)
        {
            if (txtObservacion.Text == "")
            {
                txtObservacion.Text = "Observaciones";
                txtObservacion.ForeColor = Color.Black;
            }
        }
        private void txtNumSerie_Enter(object sender, EventArgs e)
        {
            if (txtNumSerie.Text == "Numero de Serie")
            {
                txtNumSerie.Text = "";
                txtNumSerie.ForeColor = Color.Black;
            }
        }
        private void txtNumSerie_Leave(object sender, EventArgs e)
        {
            if (txtNumSerie.Text == "")
            {
                txtNumSerie.Text = "Numero de Serie";
                txtNumSerie.ForeColor = Color.Black;
            }
        }
        private void txtColor_Enter(object sender, EventArgs e)
        {
            if (txtColor.Text == "Color")
            {
                txtColor.Text = "";
                txtColor.ForeColor = Color.Black;
            }
        }
        private void txtColor_Leave(object sender, EventArgs e)
        {
            if (txtColor.Text == "")
            {
                txtColor.Text = "Color";
                txtColor.ForeColor = Color.Black;
            }
        }
        private void txtProcesador_Enter(object sender, EventArgs e)
        {
            if (txtProcesador.Text == "Procesador")
            {
                txtProcesador.Text = "";
                txtProcesador.ForeColor = Color.Black;
            }
        }
        private void txtProcesador_Leave(object sender, EventArgs e)
        {
            if (txtProcesador.Text == "")
            {
                txtProcesador.Text = "Procesador";
                txtProcesador.ForeColor = Color.Black;
            }
        }
        private void txtNumeroMac_Enter(object sender, EventArgs e)
        {
            if (txtNumeroMac.Text == "Numero Mac")
            {
                txtNumeroMac.Text = "";
                txtNumeroMac.ForeColor = Color.Black;
            }
        }
        private void txtNumeroMac_Leave(object sender, EventArgs e)
        {
            if (txtNumeroMac.Text == "")
            {
                txtNumeroMac.Text = "Numero Mac";
                txtNumeroMac.ForeColor = Color.Black;
            }
        }
        private void txtDisplay_Enter(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "Display")
            {
                txtDisplay.Text = "";
                txtDisplay.ForeColor = Color.Black;
            }
        }
        private void txtDisplay_Leave(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "Display";
                txtDisplay.ForeColor = Color.Black;
            }
        }
        private void txtNombreComercial_Enter(object sender, EventArgs e)
        {
            if (txtNombreComercial.Text == "Nombre Comercial")
            {
                txtNombreComercial.Text = "";
                txtNombreComercial.ForeColor = Color.Black;
            }
        }
        private void txtNombreComercial_Leave(object sender, EventArgs e)
        {
            if (txtNombreComercial.Text == "")
            {
                txtNombreComercial.Text = "Nombre Comercial";
                txtNombreComercial.ForeColor = Color.Black;
            }
        }

        void LimpiarCampos()
        {
            txtDescripcion.Text = txtObservacion.Text = txtNumSerie.Text = txtColor.Text
                = txtProcesador.Text
                = txtNumeroMac.Text = txtDisplay.Text = txtNombreComercial.Text = "";
        }

        //Metodos para poder cargar el comboBox con la información
        void CargarCombo()
        {
            string ConnectionString = @"Server=localhost;Database=servicedbdistribuidos;Uid=root;pwd=moises;";//Cadena de conexion a MySQL.
            string Query = "select id, nombre from marca;";
            MySqlConnection MyConn2 = new MySqlConnection(ConnectionString);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter(MyCommand2);
            DataTable dt = new DataTable();
            MyAdapter.Fill(dt);
            cbMarca.DisplayMember = "nombre";
            cbMarca.ValueMember = "id";
            cbMarca.DataSource = dt;
        }
    }
}
