using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Editorial
    {
        private string nombre;
        private int telefono;
        private string web_editorial;
        private int idEditorial;
        private static int idEditorialSiguiente = 10;


        public Editorial(string nombre, int telefono, string web_editorial)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.web_editorial = web_editorial;
            idEditorial = idEditorialSiguiente;
            idEditorialSiguiente += 10;

        }


        public string GetNombre()
        {
            return nombre;
        }

        public int GetTelefono()
        {
            return telefono;
        }

        public string GetWebEditorial()
        {
            return web_editorial;
        }

        public int GetIdEditorial()
        {
            return idEditorial;
        }



        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetTelefono(int telefono)
        {
            this.telefono = telefono;
        }

        public void SetWebEditorial(string web_editorial)
        {
            this.web_editorial = web_editorial;
        }


    }//fin class Editorial

}//fin namespace PuntoDeVentaLibreria
