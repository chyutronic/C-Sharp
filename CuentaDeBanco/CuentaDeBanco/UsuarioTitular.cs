using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco
{
    class UsuarioTitular : Usuario
    {
        public int password;

        public UsuarioTitular(string nombre, string apellido, string rut, string direccion, int telefono, int password) : base(nombre, apellido, rut, direccion, telefono)
        {
            this.password = password;

        }//fin constructor


        public void contratarProductos()
        {
            Console.WriteLine("Qué nuevo producto necesita contratar (tarjeta crédito (t), credito de consumo (c): ");
            string eleccionUsuario = Console.ReadLine();

            if(eleccionUsuario == "t")
            {
                Console.WriteLine("Su tarjeta de crédito ha sido contratada");
                Console.WriteLine(" ");

            }
            else if(eleccionUsuario == "c")
            {
                Console.WriteLine("Su crédito de consumo ha sido aprobado");
                Console.WriteLine(" ");

            }
        }


        public int cambiarContrasena(int newPassword)
        {
            this.password = newPassword;

            return this.password;
        }


    }//fin class UsuarioTitular

}//fin namespace CuentaDeBanco
