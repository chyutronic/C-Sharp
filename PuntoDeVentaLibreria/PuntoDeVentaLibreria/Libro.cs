using PuntoDeVentaLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentaLibreria
{
    internal class Libro
    {

        private string nombreTabla = "Libro";
        private string titulo;
        private string fecha_publicacion;
        private int numero_paginas;
        private double peso;
        private int precio_venta;
        private int precio_compra;
        private int cantidad;
        private int cant_autores;
        private int id_autor;
        private int id_libreria;
        private int id_editorial;
        private int id_categoria;
        private int id_estado_libro;
        private int id_bodega;
        private int id_isbn;


        public Libro(string titulo, string fecha_publicacion, int numero_paginas, double peso, int precio_venta, int precio_compra, int cantidad, int cant_autores, int id_autor, int id_libreria, int id_editorial, int id_categoria, int id_estado_libro, int id_bodega, int id_isbn)
        {

            this.titulo = titulo;
            this.fecha_publicacion = fecha_publicacion;
            this.numero_paginas = numero_paginas;
            this.peso = peso;
            this.precio_venta = precio_venta;
            this.precio_compra = precio_compra;
            this.cantidad = cantidad;
            this.cant_autores = cant_autores;
            this.id_autor = id_autor;
            this.id_libreria = id_libreria;
            this.id_editorial = id_editorial;
            this.id_categoria = id_categoria;
            this.id_estado_libro = id_estado_libro;
            this.id_bodega = id_bodega;
            this.id_isbn = id_isbn;
            
        }//fin constructor


        public Libro() { }//fin constructor 2



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



        //métodos para registrar y listar en BD

        ConexionBD conn = new ConexionBD();


        public bool registrarLibroBD()
        {
            string sql = "INSERT INTO Libro VALUES ('" + this.titulo + "', '" + this.fecha_publicacion + "', '" + this.numero_paginas + "', '" + this.peso + "', '" + this.precio_venta + "', '" + this.precio_compra + "', '" + this.cantidad + "', '" + this.cant_autores + "',  '" + this.id_autor + "', '" + this.id_libreria + "', '" + this.id_editorial + "', '" + this.id_categoria + "', '" + this.id_estado_libro + "', '" + this.id_bodega + "', '" + this.id_isbn + "')";
            if (conn.guardarSql(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void listarLibroBD()
        {
            foreach (DataRow item in conn.listarSql(nombreTabla).Rows)
            {
                Console.WriteLine(item["Id_libro"].ToString() + " - " + item["Titulo"].ToString() + " - " + item["Fecha_publicacion"].ToString() + " - " + item["Numero_paginas"].ToString() + " - " + item["Peso_grs"].ToString() + " - " + item["Precio_venta"].ToString() + " - " + item["Precio_compra"].ToString() + " - " + item["Cantidad"].ToString() + " - " + item["Cant_autores"].ToString() + " - " + item["Id_autor"].ToString() + " - " + item["Id_libreria"].ToString() + " - " + item["Id_editorial"].ToString() + " - " + item["Id_categoria"].ToString() + " - " + item["Id_estado_libro"].ToString() + " - " + item["Id_bodega"].ToString() + " - " + item["Id_isbn"].ToString());
            }

        }


    }//fin class Libro

}//fin namespace PuntoDeVentaLibreria
