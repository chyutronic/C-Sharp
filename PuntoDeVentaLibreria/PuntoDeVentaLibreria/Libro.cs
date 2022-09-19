using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Libro
    {

        private string titulo;
        private string fecha_publicacion;
        private int numero_paginas;
        private double peso;
        private int precio_venta;
        private int precio_compra;
        private int cantidad;
        private int cant_autores;
        private int idLibro;
        private static int idLibroSiguiente = 10;



        public Libro(string titulo, string fecha_publicacion, int numero_paginas, double peso, int precio_venta, int precio_compra, int cantidad, int cant_autores)
        {
            this.titulo = titulo;
            this.fecha_publicacion = fecha_publicacion;
            this.numero_paginas = numero_paginas;
            this.peso = peso;
            this.precio_venta = precio_venta;
            this.precio_compra = precio_compra;
            this.cantidad = cantidad;
            this.cant_autores = cant_autores;

            idLibro = idLibroSiguiente;
            idLibroSiguiente ++;


        }//fin constructor


        //properties para getters y setters
        public string TITULO
        {
            get { return titulo; }
            set { this.titulo = value; }
        }

        public string FECHA_PUBLICACION
        {
            get { return fecha_publicacion; }
            set { this.fecha_publicacion = value; }
        }

        public int NUMERO_PAGINAS
        {
            get { return numero_paginas; }
            set { this.numero_paginas = value; }
        }

        public double PESO
        {
            get { return peso; }
            set { this.peso = value; }
        }

        public int PRECIO_VENTA
        {
            get { return precio_venta; }
            set { this.precio_venta = value; }
        }

        public int PRECIO_COMPRA
        {
            get { return precio_compra; }
            set { this.precio_compra = value; }
        }

        public int CANTIDAD
        {
            get { return cantidad; }
            set { this.cantidad = value; }
        }

        public int CANT_AUTORES
        {
            get { return cant_autores; }
            set { this.cant_autores = value; }
        }

        public int ID_LIBRO
        {
            get { return idLibro; }
        }


    }//fin class Libro

}//fin namespace PuntoDeVentaLibreria
