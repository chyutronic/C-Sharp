using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco
{
    class UsuarioBipersonal : Usuario
    {
        private int password;

        public UsuarioBipersonal(string nombre, string apellido, string rut, string direccion, int telefono, int password) : base(nombre, apellido, rut, direccion, telefono)
        {
            this.password = password;   

        }//fin constructor



        public int PASSWORD
        {
            get { return password; }

            set { this.password = cambiarContrasena(value); }
        }



        public int cambiarContrasena(int newPassword)
        {
            this.password = newPassword;

            return this.password;
        }


    }//fin class UsuarioBipersonal
}//fin namespace CuentaDeBanco
