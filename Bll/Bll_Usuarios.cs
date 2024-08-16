using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsessLogic;

namespace BusinessLogicLayer
{
    public class Bll_Usuarios
    {
        private Dall_Usuarios dall_Usuarios;
        public Bll_Usuarios()
        {
            dall_Usuarios = new Dall_Usuarios();
        }
        public bool ValidarUsuarios(string mail, string password)
        {
           return dall_Usuarios.ValidarUsuarios(mail, password);
        }
        public bool Crear_Usuario(string mail, string password, string conpassword)
        {
            if (!ValidarEmail(mail) || password != conpassword)
            {
                return false;
            }
            return dall_Usuarios.Argregar_Usuario(mail, password);
        }
        private bool ValidarEmail(string email)
        {
            // Lógica de validación del correo electrónico
            // Puedes utilizar expresiones regulares u otras técnicas
            return email.EndsWith("@gmail.com") ||
                   email.EndsWith("@hotmail.com") ||
                   email.EndsWith("@alumnos.com") ||
                   email.EndsWith("@alumnos.ar") ||
                   email.EndsWith("@alumnos.net");
        }
    }
}
