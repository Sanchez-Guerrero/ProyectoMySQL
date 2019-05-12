using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErikWin.Views.Login
{
    public partial class frmLogin : Form
    {
        public string email = "moises0968@outlook.com";
        string password = "123";
        public frmLogin()
        {
            InitializeComponent();
        }
       
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text == email && txtPassword.Text == password)
            {
                MessageBox.Show("Bienvenido " + txtEmail.Text);
                LimpiarCampos();
                this.Hide();
                frmRegistroGeneral frmregistroGeneral = new frmRegistroGeneral();
                frmregistroGeneral.Show();
            }
            else
            {
                MessageBox.Show("Email o Password incorrectos");
                LimpiarCampos();
            }
        }

        void LimpiarCampos()
        {
            txtEmail.Text = txtPassword.Text = "";
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
