using ProyectoErikWin.Views;
using ProyectoErikWin.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoErikWin.Controller.Login
{
    public class LoginController
    {
        //Creamos el controlador del login para poder usarlo en la vista.
        frmLogin frm = new frmLogin();
        public string ema = "moises0968@outlook.com";
        string pass = "123";
        public void Loguear(string email,string password)
        {
            if (email == ema && password == pass)
            {
                MessageBox.Show("Bienvenido " + email);
                LimpiarCampos();
                frmRegistroGeneral frmregistroGeneral = new frmRegistroGeneral();
                frmregistroGeneral.Show();
            }
            else
            {
                MessageBox.Show("Email o Password incorrectos");
                frm.Show();
                LimpiarCampos();
            }
        }
        void LimpiarCampos()
        {       
            frm.txtEmail.Text = frm.txtPassword.Text = "";
        }
    }
}
