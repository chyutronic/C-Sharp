using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta
{
    internal class Producto
    {
        private string nombre;
        private int precio;
        private string categoria;
        private int cantidad;
        private int codigo;
        private static int codigoSiguiente = 1;


        public Producto(string nombre, int precio, string categoria, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
            this.cantidad = cantidad;
            codigo = codigoSiguiente;
            codigoSiguiente++;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetPrecio(int precio)
        {
            this.precio = precio;
        }

        public void SetCategoria(string categoria)
        {
            this.categoria = categoria;
        }

        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetPrecio()
        {
            return precio;
        }

        public string GetCategoria()
        {
            return categoria;
        }

        public int GetCantidad()
        {
            return cantidad;
        }


    }//fin clase Producto

}//fin nameSpace PuntoVenta
