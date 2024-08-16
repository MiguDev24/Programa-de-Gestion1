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
    public partial class frmAgregarUser : Form
    {
        private Bll_Usuarios bll_Usuarios;
        public frmAgregarUser()
        {
            InitializeComponent();
            bll_Usuarios = new Bll_Usuarios();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            string email = txtboxmail.Text;
            string contraseña = txtboxcontraseña.Text;
            string concontraseña = txtboxconcontra.Text;
            if(Crear_Usuario(email,contraseña,concontraseña))
            {
                MessageBox.Show("USUARIO CREADO");
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR AL CREAR USUARIO, VERIFICAR DATOS");
            }
        }
        private bool Crear_Usuario(string email, string contraseña, string confContraseña)
        {
            return bll_Usuarios.Crear_Usuario(email, contraseña, confContraseña);
        }
    }
}
