using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal abstract class Persona
    {

        private string nombre;
        private string apellido;
        private string mail;
        private int telefono;


        public Persona(string nombre, string apellido, string mail, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mail = mail;
            this.telefono = telefono;

        }//fin constructor


        //métodos setters
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void SetMail(string mail)
        {
            this.mail = mail;
        }

        public void SetTelefono(int telefono)
        {
            this.telefono = telefono;
        }


        //métodos getters


        public string GetNombre()
        {
            return nombre;
        }

        public string GetApellido()
        {
            return apellido;
        }

        public string GetMail()
        {
            return mail;
        }

        public int GetTelefono()
        {
            return telefono;
        }


    }//fin class Persona

}//fin namespace PuntoDeVentaLibreria

