using ProyectoErikWin.Controller.Login;
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
        public frmLogin()
        {
            InitializeComponent();
        } 
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            LoginController ctrlLogin = new LoginController();
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            ctrlLogin.Loguear(email,password);
            this.Hide();   
        }
        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Las acciones Enter y Leave nos sirven para realizar el placeholder como html.
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Black;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
