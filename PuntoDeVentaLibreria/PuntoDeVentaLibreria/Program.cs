using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace PuntoDeVentaLibreria
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            Libro miLibro = new Libro();
            Autor miAutor = new Autor();
            Co_autor miCoAutor = new Co_autor();
            Co_co_autor miCoCoAutor = new Co_co_autor();
            Vendedor miVendedor = new Vendedor();
            Repartidor miRepartidor = new Repartidor();
            Venta miVenta = new Venta();
            Nota_credito miNotaCredito = new Nota_credito();
            Guia_despacho miGuiaDespacho = new Guia_despacho();


            Libreria miLibreria = new Libreria("Altamira", "Las dalias 1240, Ñuñoa");

            /*
            List<Venta> listaVentas = new List<Venta>();
            List<Libro> listaLibros = new List<Libro>();
            List<Vendedor> listaVendedores = new List<Vendedor>();
            List<Autor> listaAutores = new List<Autor>();
            List<Co_autor> listaCoAutores = new List<Co_autor>();
            List<Co_co_autor> listaCoCoAutores = new List<Co_co_autor>();
            List<Repartidor> listaRepartidores = new List<Repartidor>();
            List<Guia_despacho> listaGuiaDespacho = new List<Guia_despacho>();
            List<Nota_credito> listaNotaCredito = new List<Nota_credito>();
            */


            string op = "0";


            while (op != "7")
            {

                Console.WriteLine("MENU:");
                Console.WriteLine(miLibreria.GetNombre() + " - " + miLibreria.GetDireccion());
                Console.WriteLine("");
                Console.WriteLine("1. Registrar Libros");
                Console.WriteLine("2. Registrar Autores, Co-autores ó Co-co-autores");
                Console.WriteLine("3. Registrar Vendedores o Repartidores");
                Console.WriteLine("4. Registrar Nota Crédito o Guia Despacho");
                Console.WriteLine("5. Mostrar listas");
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

                    Console.WriteLine("Ingrese el Id del autor: ");
                    int idAutor_ingresado = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Id de la Libreria: ");
                    int idLibreria_ingresado = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Id de la Editorial: ");
                    int idEditorial_ingresado = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Id de la Categoria: ");
                    int idCategoria_ingresado = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Id del Estado del Libro: ");
                    int idEstadoLibro_ingresado = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Id de la bodega: ");
                    int idBodega_ingresado = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Id del Isbn: ");
                    int idIsbn_ingresado = int.Parse(Console.ReadLine());


                    Libro L = new Libro(titulo_ingresado, fechaPublicacion_ingresado, numeroPaginas_ingresado, peso_ingresado, precioVenta_ingresado, precioCompra_ingresado, cantidad_ingresado, cantAutores_ingresado, idAutor_ingresado, idLibreria_ingresado, idEditorial_ingresado, idCategoria_ingresado, idEstadoLibro_ingresado, idBodega_ingresado, idIsbn_ingresado);

                    L.registrarLibroBD();

                    Console.WriteLine(" ");
                    Console.WriteLine("Libro listado correctamente en BD..!");
                    Console.WriteLine(" ");

                    //listaLibros.Add(L);

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

                            A.registrarAutorBD();

                            Console.WriteLine(" ");
                            Console.WriteLine("Autor registrado correctamente..!");
                            Console.WriteLine(" ");

                            //listaAutores.Add(A);

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

                            Console.WriteLine("Ingrese el Id del Autor correspondiente: ");
                            int idAutor_ingresado = int.Parse(Console.ReadLine());


                            Co_autor CA = new Co_autor(nombreCoAutor_ingresado, apellidoCoAutor_ingresado, mailCoAutor_ingresado, telefonoCoAutor_ingresado, idAutor_ingresado);

                            CA.registrarCoAutorBD();

                            Console.WriteLine(" ");
                            Console.WriteLine("Co-autor registrado correctamente..!");
                            Console.WriteLine(" ");

                            //listaCoAutores.Add(CA);

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

                            Console.WriteLine("Ingrese el Id del Co-autor correspondiente: ");
                            int idCoAutor_ingresado = int.Parse(Console.ReadLine());


                            Co_co_autor CCA = new Co_co_autor(nombreCoCoAutor_ingresado, apellidoCoCoAutor_ingresado, mailCoCoAutor_ingresado, telefonoCoCoAutor_ingresado, idCoAutor_ingresado);

                            CCA.registrarCoCoAutorBD();

                            Console.WriteLine(" ");
                            Console.WriteLine("Co-co-autor registrado correctamente..!");
                            Console.WriteLine(" ");

                            //listaCoCoAutores.Add(CCA);

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

                            VE.registrarVendedorBD();

                            Console.WriteLine(" ");
                            Console.WriteLine("Vendedor registrado correctamente..!");
                            Console.WriteLine(" ");

                            //listaVendedores.Add(VE);

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

                            R.registrarRepartidorBD();

                            Console.WriteLine(" ");
                            Console.WriteLine("Repartidor registrado correctamente..!");
                            Console.WriteLine(" ");

                            //listaRepartidores.Add(R);

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
                    while (op != "c")
                    {

                        Console.WriteLine("MENU:");
                        Console.WriteLine(miLibreria.GetNombre() + " - " + miLibreria.GetDireccion());
                        Console.WriteLine("");
                        Console.WriteLine("¿Qué desea registrar?: ");
                        Console.WriteLine("");
                        Console.WriteLine("a. Registrar Nota de Crédito");
                        Console.WriteLine("b. Registrar Guía de Despacho");
                        Console.WriteLine("c. Volver al menú principal");
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite una opción: ");

                        op = Console.ReadLine();

                        Console.WriteLine(" ");


                        if (op == "a")
                        {
                            Console.WriteLine("Ingrese el título del libro y/o detalle: ");
                            string detalle_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese la fecha (AAAA-MM-DD): ");
                            string fecha_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese las observaciones: ");
                            string observaciones_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el Id de la venta correspondiente: ");
                            int idVenta_ingresado = int.Parse(Console.ReadLine());


                            Nota_credito NC = new Nota_credito(detalle_ingresado, fecha_ingresado, observaciones_ingresado, idVenta_ingresado);

                            NC.registrarNotaCreditoBD();

                            Console.WriteLine(" ");
                            Console.WriteLine("Nota de Crédito registrada correctamente en BD..!");
                            Console.WriteLine(" ");

                            //listaNotaCredito.Add(NC);

                        }

                        if (op == "b")
                        {
                            Console.WriteLine("Ingrese el título del libro y/o detalle: ");
                            string detalle_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese la fecha (AAAA-MM-DD): ");
                            string fecha_ingresado = Console.ReadLine();

                            Console.WriteLine("Ingrese el estado de la entrega (entregado=1, no entregado=0");
                            int estado_ingresado = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el Id de la venta correspondiente: ");
                            int idVenta_ingresado = int.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese el Id del repartidor correspondiente: ");
                            int idRepartidor_ingresado = int.Parse(Console.ReadLine());


                            Guia_despacho GD = new Guia_despacho(detalle_ingresado, fecha_ingresado, estado_ingresado, idVenta_ingresado, idRepartidor_ingresado);

                            GD.registrarGuiaDespachoBD();

                            Console.WriteLine(" ");
                            Console.WriteLine("Guía de Despacho registrada correctamente en BD..!");
                            Console.WriteLine(" ");

                            //listaGuiaDespacho.Add(GD);

                        }
                        else if (op == "c")
                        {
                            Console.WriteLine("Volviendo al menú principal..!");
                            Console.WriteLine(" ");
                        }

                    }//fin while anidado

                }//fin if OP == 4


                else if (op == "5")
                {
                    while(op != "j")
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
                        Console.WriteLine("h. Lista de Notas de Crédito");
                        Console.WriteLine("i. Lista de Guías de despacho");
                        Console.WriteLine("j. Volver al menú principal");
                        Console.WriteLine(" ");
                        Console.WriteLine("Digite una opción: ");

                        op = Console.ReadLine();

                        Console.WriteLine(" ");


                        if (op == "a")
                        {
                            Console.WriteLine("Lista de Libros:");
                            Console.WriteLine("");

                            miLibro.listarLibroBD();
                            Console.WriteLine("");


                            /*listaLibros.ForEach(l => {
                                Console.WriteLine(l.ID_LIBRO + " - " + l.TITULO + " - " + l.FECHA_PUBLICACION + " - " + l.NUMERO_PAGINAS + " - " + l.PESO + " - " + l.PRECIO_VENTA + " - " + l.PRECIO_COMPRA + " - " + l.CANTIDAD + " - " + l.CANT_AUTORES); 
                                Console.WriteLine(" "); 
                            });*/

                        }
                        else if (op == "b")
                        {
                            Console.WriteLine("Lista de Autores:");
                            Console.WriteLine("");

                            miAutor.listarAutorBD();
                            Console.WriteLine("");


                            /*listaAutores.ForEach(a => { 
                                Console.WriteLine(a.GetIdAutor() + " - " + a.GetNombre() + " - " + a.GetApellido() + " - " + a.GetMail() + " - " + a.GetTelefono());
                                Console.WriteLine(" ");
                            });*/

                        }
                        else if (op == "c")
                        {
                            Console.WriteLine("Lista de Co-autores:");
                            Console.WriteLine("");

                            miCoAutor.listarCoAutorBD();
                            Console.WriteLine("");


                            /*listaCoAutores.ForEach(ca => {
                                Console.WriteLine(ca.GetIdCoAutor() + " - " + ca.GetNombre() + " - " + ca.GetApellido() + " - " + ca.GetMail() + " - " + ca.GetTelefono());
                                Console.WriteLine(" ");
                            });*/

                        }
                        else if (op == "d")
                        {
                            Console.WriteLine("Lista de Co-co-autores:");
                            Console.WriteLine("");

                            miCoCoAutor.listarCoCoAutorBD();
                            Console.WriteLine("");


                            /*listaCoCoAutores.ForEach(cca => {
                                Console.WriteLine(cca.GetIdCoCoAutor() + " - " + cca.GetNombre() + " - " + cca.GetApellido() + " - " + cca.GetMail() + " - " + cca.GetTelefono());
                                Console.WriteLine(" ");
                            });*/

                        }
                        else if (op == "e")
                        {
                            Console.WriteLine("Lista de Vendedores:");
                            Console.WriteLine("");

                            miVendedor.listarVendedorBD();
                            Console.WriteLine("");


                            /*listaVendedores.ForEach(ve => {
                                Console.WriteLine(ve.GetIdVendedor() + " - " + ve.GetNombre() + " - " + ve.GetApellido() + " - " + ve.GetMail() + " - " + ve.GetTelefono());
                                Console.WriteLine(" ");
                            });*/

                        }
                        else if (op == "f")
                        {
                            Console.WriteLine("Lista de Repartidores:");
                            Console.WriteLine("");

                            miRepartidor.listarRepartidorBD();
                            Console.WriteLine("");


                            /*listaRepartidores.ForEach(r => {
                                Console.WriteLine(r.GetIdRepartidor() + " - " + r.GetNombre() + " - " + r.GetApellido() + " - " + r.GetMail() + " - " + r.GetTelefono());
                                Console.WriteLine(" ");
                            });*/

                        }
                        else if (op == "g")
                        {
                            Console.WriteLine("Lista de Ventas:");
                            Console.WriteLine("");

                            miVenta.listarVentaBD(); 
                            Console.WriteLine("");


                            /*listaVentas.ForEach(v => {
                                Console.WriteLine(v.GetIdVenta() + " - " + v.GetFecha() + " - " + v.GetDetalle() + " - " + v.GetMedioPago());
                                Console.WriteLine(" ");
                            });*/

                        }
                        else if (op == "h")
                        {
                            Console.WriteLine("Lista de Notas de crédito:");
                            Console.WriteLine("");

                            miNotaCredito.listarNotaCreditoBD();
                            Console.WriteLine("");


                        }
                        else if (op == "i")
                        {
                            Console.WriteLine("Lista de Guías de despacho:");
                            Console.WriteLine("");

                            miGuiaDespacho.listarGuiaDespachoBD();
                            Console.WriteLine("");


                        }
                        else if (op == "j")
                        {
                            Console.WriteLine("Volviendo al menú principal..!");
                            Console.WriteLine(" ");
                        }

                    }//fin while anidado

                }//fin if OP == 5


                else if (op == "6")
                {

                    Console.WriteLine("Ingrese el monto de la Venta: ");
                    int montoVendido = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la fecha de la venta (AAAA-MM-DD): ");
                    string fechaVendido = Console.ReadLine();

                    Console.WriteLine("Ingrese título del libro o detalle de la venta: ");
                    string detalleVendido = Console.ReadLine();

                    Console.WriteLine("Ingrese medio de pago (credito o debito): ");
                    string medioPagoVendido = Console.ReadLine();

                    Console.WriteLine("Ingrese el Id del Libro correspondiente: ");
                    int idLibroVendido = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Id de la Libreria correspondiente: ");
                    int idLibreriaVendido = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Id del Vendedor correspondiente: ");
                    int idVendedorVendido = int.Parse(Console.ReadLine());

                    Console.WriteLine(" ");


                    Venta V = new Venta(montoVendido, fechaVendido, detalleVendido, medioPagoVendido, idLibroVendido, idLibreriaVendido, idVendedorVendido);

                    V.registrarVentaBD();

                    Console.WriteLine(" ");
                    Console.WriteLine("Venta registrada correctamente en BD..!");
                    Console.WriteLine(" ");


                    /*foreach (var l in listaLibros)
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
                    }*/

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

