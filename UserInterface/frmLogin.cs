using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace UserInterface
{
    public partial class frmLogin : Form
    {
        private Bll_Usuarios bll_Usuarios;
        public frmLogin()
        {
            InitializeComponent();
            bll_Usuarios = new Bll_Usuarios();  
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            string mail = txtboxusuario.Text;
            string password = txtboxcontraseña.Text;
            if(Acceder(mail,password))
            {
                MessageBox.Show("Acceso Permitido");
                this.Hide();
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }
        private bool Acceder(string mail, string password)
        {
            return bll_Usuarios.ValidarUsuarios(mail, password);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAgregarUser frmAgregarUser = new frmAgregarUser();
            frmAgregarUser.Show();
        }
    }
}
