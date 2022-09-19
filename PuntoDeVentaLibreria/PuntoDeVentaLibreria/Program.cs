using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace PuntoDeVentaLibreria
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Libreria miLibreria = new Libreria("Altamira", "Las dalias 1240, Ñuñoa");


            List<Venta> listaVentas = new List<Venta>();
            List<Libro> listaLibros = new List<Libro>();
            List<Vendedor> listaVendedores = new List<Vendedor>();
            List<Autor> listaAutores = new List<Autor>();
            List<Co_autor> listaCoAutores = new List<Co_autor>();
            List<Co_co_autor> listaCoCoAutores = new List<Co_co_autor>();
            List<Repartidor> listaRepartidores = new List<Repartidor>();
            List<Guia_despacho> listaGuiaDespacho = new List<Guia_despacho>();


            string op = "0";


            while (op != "7")
            {

                Console.WriteLine("MENU:");
                Console.WriteLine(miLibreria.GetNombre() + " - " + miLibreria.GetDireccion());
                Console.WriteLine("");
                Console.WriteLine("1. Registrar Libros");
                Console.WriteLine("2. Registrar Autores, Co-autores ó Co-co-autores");
                Console.WriteLine("3. Registrar Vendedores o Repartidores");
                Console.WriteLine("4. Mostrar listas");
                Console.WriteLine("5. Buscar");
                Console.WriteLine("6. Hacer Venta");
                Console.WriteLine("7. Salir");
                Console.WriteLine("");
                Console.WriteLine("Digite una opción: ");

                op = Console.ReadLine();

                Console.WriteLine(" ");


                if (op == "1")
                {

                    Console.WriteLine("Ingrese el título del libro: ");
                    string titulo_ingresado = Console.ReadLine();

                    Console.WriteLine("Ingrese la fecha de publicación del libro: ");
                    string fechaPublicacion_ingresado = Console.ReadLine();

                    Console.WriteLine("Ingrese el número de páginas del libro: ");
                    int numeroPaginas_ingresado = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el peso del libro: ");
                    double peso_ingresado = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el precio de venta del libro: ");
                    int precioVenta_ingresado = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el precio de compra del libro: ");
                    int precioCompra_ingresado = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la cantidad de libros: ");
                    int cantidad_ingresado = int.Parse(Console.ReadLine());                    
                    
                    Console.WriteLine("Ingrese la cantidad de autores: ");
                    int cantAutores_ingresado = int.Parse(Console.ReadLine());


                    Libro L = new Libro(titulo_ingresado, fechaPublicacion_ingresado, numeroPaginas_ingresado, peso_ingresado, precioVenta_ingresado, precioCompra_ingresado, cantidad_ingresado, cantAutores_ingresado);
                    
                    Console.WriteLine(" ");
                    Console.WriteLine("Libro listado correctamente..!\n"+ L.ID_LIBRO + " - " + L.TITULO + " - " + L.FECHA_PUBLICACION + " - " + L.NUMERO_PAGINAS + " - " + L.PESO + " - " + L.PRECIO_VENTA + " - " + L.PRECIO_COMPRA + " - " + L.CANTIDAD + " - " + L.CANT_AUTORES);
                    Console.WriteLine(" ");

                    listaLibros.Add(L);

                }//fin if OP == 1


                else if (op == "2")
                {
                    while (op != "d")
                    {
                        Console.WriteLine("MENU:");
                        Console.WriteLine(miLibreria.GetNombre() + " - " + miLibreria.GetDireccion());
                        Console.WriteLine("");
                        Console.WriteLine("¿Qué desea registrar?: ");
                        Console.WriteLine("");
                        Console.WriteLine("a. Registrar Autores");
                        Console.WriteLine("b. Registrar Co-autores");
                        Console.WriteLine("c. Registrar Co-co-autores");
                        Console.WriteLine("d. Volver al menú principal");
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite una opción: ");

                        op = Console.ReadLine();

                        Console.WriteLine(" ");


                        if (op == "a")
                        {
                            Console.WriteLine("Ingrese el nombre del Autor: ");
                            string nombreAutor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el apellido del Autor: ");
                            string apellidoAutor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el mail del Autor: ");
                            string mailAutor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el telefono del Autor: ");
                            int telefonoAutor_ingresado = int.Parse(Console.ReadLine());


                            Autor A = new Autor(nombreAutor_ingresado, apellidoAutor_ingresado, mailAutor_ingresado, telefonoAutor_ingresado);

                            Console.WriteLine(" ");
                            Console.WriteLine("Autor registrado correctamente..!\n" + A.GetIdAutor() + " - " + A.GetNombre() + " - " + A.GetApellido() + " - " + A.GetMail() + " - " + A.GetTelefono());
                            Console.WriteLine(" ");

                            listaAutores.Add(A);

                        }
                        else if (op == "b")
                        {
                            Console.WriteLine("Ingrese el nombre del Co-autor: ");
                            string nombreCoAutor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el apellido del Co-autor: ");
                            string apellidoCoAutor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el mail del Co-autor: ");
                            string mailCoAutor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el telefono del Co-autor: ");
                            int telefonoCoAutor_ingresado = int.Parse(Console.ReadLine());


                            Co_autor CA = new Co_autor(nombreCoAutor_ingresado, apellidoCoAutor_ingresado, mailCoAutor_ingresado, telefonoCoAutor_ingresado);

                            Console.WriteLine(" ");
                            Console.WriteLine("Co-autor registrado correctamente..!\n" + CA.GetIdCoAutor() + " - " + CA.GetNombre() + " - " + CA.GetApellido() + " - " + CA.GetMail() + " - " + CA.GetTelefono());
                            Console.WriteLine(" ");

                            listaCoAutores.Add(CA);

                        }
                        else if (op == "c")
                        {
                            Console.WriteLine("Ingrese el nombre del Co-co-autor: ");
                            string nombreCoCoAutor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el apellido del Co-co-autor: ");
                            string apellidoCoCoAutor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el mail del Co-co-autor: ");
                            string mailCoCoAutor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el telefono del Co-co-autor: ");
                            int telefonoCoCoAutor_ingresado = int.Parse(Console.ReadLine());


                            Co_co_autor CCA = new Co_co_autor(nombreCoCoAutor_ingresado, apellidoCoCoAutor_ingresado, mailCoCoAutor_ingresado, telefonoCoCoAutor_ingresado);

                            Console.WriteLine(" ");
                            Console.WriteLine("Co-co-autor registrado correctamente..!\n" + CCA.GetIdCoCoAutor() + " - " + CCA.GetNombre() + " - " + CCA.GetApellido() + " - " + CCA.GetMail() + " - " + CCA.GetTelefono());
                            Console.WriteLine(" ");

                            listaCoCoAutores.Add(CCA);

                        }
                        else if (op == "d")
                        {
                            Console.WriteLine("Volviendo al menú principal..!");
                            Console.WriteLine(" ");
                        }

                    }//fin while anidado

                }//fin if OP == 2


                else if ( op == "3")
                {
                    while(op != "c")
                    {

                        Console.WriteLine("MENU:");
                        Console.WriteLine(miLibreria.GetNombre() + " - " + miLibreria.GetDireccion());
                        Console.WriteLine("");
                        Console.WriteLine("¿Qué desea registrar?: ");
                        Console.WriteLine("");
                        Console.WriteLine("a. Registrar Vendedores");
                        Console.WriteLine("b. Registrar Repartidores");
                        Console.WriteLine("c. Volver al menú principal");
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite una opción: ");

                        op = Console.ReadLine();

                        Console.WriteLine(" ");


                        if (op == "a")
                        {
                            Console.WriteLine("Ingrese el nombre del Vendedor: ");
                            string nombreVendedor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el apellido del Vendedor: ");
                            string apellidoVendedor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el mail del Vendedor: ");
                            string mailVendedor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el telefono del Vendedor: ");
                            int telefonoVendedor_ingresado = int.Parse(Console.ReadLine());


                            Vendedor VE = new Vendedor(nombreVendedor_ingresado, apellidoVendedor_ingresado, mailVendedor_ingresado, telefonoVendedor_ingresado);

                            Console.WriteLine(" ");
                            Console.WriteLine("Vendedor registrado correctamente..!\n" + VE.GetIdVendedor() + " - " + VE.GetNombre() + " - " + VE.GetApellido() + " - " + VE.GetMail() + " - " + VE.GetTelefono());
                            Console.WriteLine(" ");

                            listaVendedores.Add(VE);

                        }
                        else if (op == "b")
                        {
                            Console.WriteLine("Ingrese el nombre del Repartidor: ");
                            string nombreRepartidor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el apellido del Repartidor: ");
                            string apellidoRepartidor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el mail del Repartidor: ");
                            string mailRepartidor_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el telefono del Repartidor: ");
                            int telefonoRepartidor_ingresado = int.Parse(Console.ReadLine());


                            Repartidor R = new Repartidor(nombreRepartidor_ingresado, apellidoRepartidor_ingresado, mailRepartidor_ingresado, telefonoRepartidor_ingresado);

                            Console.WriteLine(" ");
                            Console.WriteLine("Repartidor registrado correctamente..!\n" + R.GetIdRepartidor() + " - " + R.GetNombre() + " - " + R.GetApellido() + " - " + R.GetMail() + " - " + R.GetTelefono());
                            Console.WriteLine(" ");

                            listaRepartidores.Add(R);

                        }
                        else if (op == "c")
                        {
                            Console.WriteLine("Volviendo al menú principal..!");
                            Console.WriteLine(" ");
                        }

                    }//fin while anidado

                }//fin if OP == 3


                else if (op == "4")
                {
                    while(op != "h")
                    {

                        Console.WriteLine("MENU:");
                        Console.WriteLine(miLibreria.GetNombre() + " - " + miLibreria.GetDireccion());
                        Console.WriteLine("");
                        Console.WriteLine("¿Qué lista desea revisar?: ");
                        Console.WriteLine("");
                        Console.WriteLine("a. Lista de Libros");
                        Console.WriteLine("b. Lista de Autores");
                        Console.WriteLine("c. Lista de Co-autores");
                        Console.WriteLine("d. Lista de Co-co-autores");
                        Console.WriteLine("e. Lista de Vendedores");
                        Console.WriteLine("f. Lista de Repartidores");
                        Console.WriteLine("g. Lista de Ventas");
                        Console.WriteLine("h. Volver al menú principal");
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite una opción: ");

                        op = Console.ReadLine();

                        Console.WriteLine(" ");


                        if (op == "a")
                        {
                            Console.WriteLine("Lista de Libros:");

                            listaLibros.ForEach(l => {
                                Console.WriteLine(l.ID_LIBRO + " - " + l.TITULO + " - " + l.FECHA_PUBLICACION + " - " + l.NUMERO_PAGINAS + " - " + l.PESO + " - " + l.PRECIO_VENTA + " - " + l.PRECIO_COMPRA + " - " + l.CANTIDAD + " - " + l.CANT_AUTORES); 
                                Console.WriteLine(" "); 
                            });
                        }
                        else if (op == "b")
                        {
                            Console.WriteLine("Lista de Autores:");

                            listaAutores.ForEach(a => { 
                                Console.WriteLine(a.GetIdAutor() + " - " + a.GetNombre() + " - " + a.GetApellido() + " - " + a.GetMail() + " - " + a.GetTelefono());
                                Console.WriteLine(" ");
                            });
                        }
                        else if (op == "c")
                        {
                            Console.WriteLine("Lista de Co-autores:");

                            listaCoAutores.ForEach(ca => {
                                Console.WriteLine(ca.GetIdCoAutor() + " - " + ca.GetNombre() + " - " + ca.GetApellido() + " - " + ca.GetMail() + " - " + ca.GetTelefono());
                                Console.WriteLine(" ");
                            });
                        }
                        else if (op == "d")
                        {
                            Console.WriteLine("Lista de Co-co-autores:");

                            listaCoCoAutores.ForEach(cca => {
                                Console.WriteLine(cca.GetIdCoCoAutor() + " - " + cca.GetNombre() + " - " + cca.GetApellido() + " - " + cca.GetMail() + " - " + cca.GetTelefono());
                                Console.WriteLine(" ");
                            });
                        }
                        else if (op == "e")
                        {
                            Console.WriteLine("Lista de Vendedores:");

                            listaVendedores.ForEach(ve => {
                                Console.WriteLine(ve.GetIdVendedor() + " - " + ve.GetNombre() + " - " + ve.GetApellido() + " - " + ve.GetMail() + " - " + ve.GetTelefono());
                                Console.WriteLine(" ");
                            });
                        }
                        else if (op == "f")
                        {
                            Console.WriteLine("Lista de Repartidores:");

                            listaRepartidores.ForEach(r => {
                                Console.WriteLine(r.GetIdRepartidor() + " - " + r.GetNombre() + " - " + r.GetApellido() + " - " + r.GetMail() + " - " + r.GetTelefono());
                                Console.WriteLine(" ");
                            });
                        }
                        else if (op == "g")
                        {
                            Console.WriteLine("Lista de Ventas:");

                            listaVentas.ForEach(v => {
                                Console.WriteLine(v.GetIdVenta() + " - " + v.GetFecha() + " - " + v.GetDetalle() + " - " + v.GetMedioPago());
                                Console.WriteLine(" ");
                            });
                        }
                        else if (op == "h")
                        {
                            Console.WriteLine("Volviendo al menú principal..!");
                            Console.WriteLine(" ");
                        }

                    }//fin while anidado

                }//fin if OP == 4


                else if (op == "5")
                {
                    while (op != "h")
                    {
                        Console.WriteLine("MENU:");
                        Console.WriteLine(miLibreria.GetNombre() + " - " + miLibreria.GetDireccion());
                        Console.WriteLine("");
                        Console.WriteLine("¿Qué desea buscar?: ");
                        Console.WriteLine("");
                        Console.WriteLine("a. Libro");
                        Console.WriteLine("b. Autor");
                        Console.WriteLine("c. Co-autor");
                        Console.WriteLine("d. Co-co-autor");
                        Console.WriteLine("e. Vendedor");
                        Console.WriteLine("f. Repartidor");
                        Console.WriteLine("g. Venta");
                        Console.WriteLine("h. Volver al menú principal");
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite una opción: ");

                        op = Console.ReadLine();

                        Console.WriteLine(" ");


                        if (op == "a") 
                        {
                            Console.WriteLine("Ingrese el codigo del Libro: ");
                            int buscado = int.Parse(Console.ReadLine());

                            listaLibros.ForEach(l =>
                            {
                                if (l.ID_LIBRO == buscado) Console.WriteLine("Libro encontrado con éxito..!\n" + l.ID_LIBRO + " - " + l.TITULO + " - " + l.FECHA_PUBLICACION + " - " + l.NUMERO_PAGINAS + " - " + l.PESO + " - " + l.PRECIO_VENTA + " - " + l.PRECIO_COMPRA + " - " + l.CANTIDAD + " - " + l.CANT_AUTORES);
                                else Console.WriteLine("Libro no encontrado, vuelva a intentarlo...");
                                Console.WriteLine(" ");
                            });

                        }
                        else if (op == "b")
                        {
                            Console.WriteLine("Ingrese el apellido del Autor: ");
                            string buscado = Console.ReadLine();

                            listaAutores.ForEach(a =>
                            {
                                if (a.GetApellido() == buscado) Console.WriteLine("Autor encontrado con éxito..!\n" + a.GetIdAutor() + " - " + a.GetNombre() + " - " + a.GetApellido() + " - " + a.GetMail() + " - " + a.GetTelefono());
                                else Console.WriteLine("Autor no encontrado, vuelva a intentarlo...");
                                Console.WriteLine(" ");
                            });

                        }
                        else if (op == "c")
                        {
                            Console.WriteLine("Ingrese el apellido del Co-autor: ");
                            string buscado = Console.ReadLine();

                            listaCoAutores.ForEach(ca =>
                            {
                                if (ca.GetApellido() == buscado) Console.WriteLine("Co-autor encontrado con éxito..!\n" + ca.GetIdCoAutor() + " - " + ca.GetNombre() + " - " + ca.GetApellido() + " - " + ca.GetMail() + " - " + ca.GetTelefono());
                                else Console.WriteLine("Co-autor no encontrado, vuelva a intentarlo...");
                                Console.WriteLine(" ");
                            });

                        }
                        else if (op == "d")
                        {
                            Console.WriteLine("Ingrese el apellido del Co-co-autor: ");
                            string buscado = Console.ReadLine();

                            listaCoCoAutores.ForEach(cca =>
                            {
                                if (cca.GetApellido() == buscado) Console.WriteLine("Co-co-autor encontrado con éxito..!\n" + cca.GetIdCoCoAutor() + " - " + cca.GetNombre() + " - " + cca.GetApellido() + " - " + cca.GetMail() + " - " + cca.GetTelefono());
                                else Console.WriteLine("Co-co-autor no encontrado, vuelva a intentarlo...");
                                Console.WriteLine(" ");
                            });

                        }
                        else if (op == "e")
                        {
                            Console.WriteLine("Ingrese el apellido del Vendedor: ");
                            string buscado = Console.ReadLine();

                            listaVendedores.ForEach(ve =>
                            {
                                if (ve.GetApellido() == buscado) Console.WriteLine("Vendedor encontrado con éxito..!\n" + ve.GetIdVendedor() + " - " + ve.GetNombre() + " - " + ve.GetApellido() + " - " + ve.GetMail() + " - " + ve.GetTelefono());
                                else Console.WriteLine("Vendedor no encontrado, vuelva a intentarlo...");
                                Console.WriteLine(" ");
                            });

                        }
                        else if (op == "f")
                        {
                            Console.WriteLine("Ingrese el apellido del Repartidor: ");
                            string buscado = Console.ReadLine();

                            listaRepartidores.ForEach(r =>
                            {
                                if (r.GetApellido() == buscado) Console.WriteLine("Repartidor encontrado con éxito..!\n" + r.GetIdRepartidor() + " - " + r.GetNombre() + " - " + r.GetApellido() + " - " + r.GetMail() + " - " + r.GetTelefono());
                                else Console.WriteLine("Repartidor no encontrado, vuelva a intentarlo...");
                                Console.WriteLine(" ");
                            });

                        }
                        else if (op == "g")
                        {
                            Console.WriteLine("Ingrese el codigo de la Venta: ");
                            int buscado = int.Parse(Console.ReadLine());

                            listaVentas.ForEach(v =>
                            {
                                if (v.GetIdVenta() == buscado) Console.WriteLine("Venta encontrada con éxito..!\n" + v.GetIdVenta() + " - " + v.GetFecha() + " - " + v.GetDetalle() + " - " + v.GetTotal() + " - " + v.GetMedioPago());
                                else Console.WriteLine("Venta no encontrada, vuelva a intentarlo...");
                                Console.WriteLine(" ");
                            });

                        }
                        else if (op == "h")
                        {
                            Console.WriteLine("Volviendo al menú principal..!");
                            Console.WriteLine(" ");
                        }

                    }//fin while anidado

                }//fin if OP == 5


                else if (op == "6")
                {

                    Console.WriteLine("Ingrese el codigo del libro: ");
                    string codigoVendido = Console.ReadLine();

                    Console.WriteLine("Ingrese cantidad: ");
                    int cantidadVendido = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese fecha: ");
                    string fechaVendido = Console.ReadLine();

                    Console.WriteLine("Ingrese medio de pago (credito o debito): ");
                    string medioPagoVendido = Console.ReadLine();

                    Console.WriteLine(" ");


                    foreach (var l in listaLibros)
                    {

                        if (l.ID_LIBRO == int.Parse(codigoVendido))
                        {
                            String detalleVendido = l.TITULO;
                            int totalVendido = cantidadVendido * l.PRECIO_VENTA;

                            Venta V = new Venta(fechaVendido, detalleVendido, totalVendido, medioPagoVendido);

                            listaVentas.Add(V);

                            l.CANTIDAD = (l.CANTIDAD - cantidadVendido);

                            Console.WriteLine("Venta exitosa..!");
                            Console.WriteLine(V.GetIdVenta() + " - " + V.GetFecha() + " - " + V.GetDetalle() + " - " + V.GetTotal() + " - " + V.GetMedioPago());
                            Console.WriteLine(" ");
                        }
                    }

                }//fin if OP == 6


                else if (op == "7")
                {
                    Console.WriteLine("Gracias por usar esta aplicación..!");
                    Console.WriteLine(" ");
                    Console.ReadLine();

                }//fin if OP == 7


            }//fin while principal

        }//fin método Main

    }//fin class Program

}//fin namespace PuntoDeVentaLibreria

