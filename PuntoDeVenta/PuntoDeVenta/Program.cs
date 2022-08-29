// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;

namespace PuntoDeVenta
{
    class Program
    {
        static void Main()
        {

            Local Nunoa = new Local("Tía Juanita", "Las dalias 1298");

            List<Producto> listaProductos = new List<Producto>();
            List<Venta> listaVentas = new List<Venta>();

            string op = "0";


            while (op != "6")
            {
                Console.WriteLine("MENU:");
                Console.WriteLine(Nunoa.GetNombre() + " - " + Nunoa.GetDireccion());
                Console.WriteLine("");
                Console.WriteLine("1. Registrar Producto");
                Console.WriteLine("2. Borrar Producto");
                Console.WriteLine("3. Mostrar lista de Productos");
                Console.WriteLine("4. Hacer Venta");
                Console.WriteLine("5. Mostrar lista de Ventas");
                Console.WriteLine("6. Salir");
                Console.WriteLine("");
                Console.WriteLine("Digite una opción: ");

                op = Console.ReadLine();


                if(op == "1")
                {
                    Console.WriteLine("Ingrese el nombre del producto: ");
                    String nombreProducto = Console.ReadLine();                    

                    Console.WriteLine("Ingrese el precio del producto: ");
                    int precioProducto = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la categoria del producto: ");
                    string categoriaProducto = Console.ReadLine();

                    Console.WriteLine("Ingrese la cantidad del producto: ");
                    int cantidadProducto = int.Parse(Console.ReadLine());

                    Producto P = new Producto(nombreProducto, precioProducto, categoriaProducto, cantidadProducto);
                    Console.WriteLine("Producto listado correctamente..!\n" + P.GetCodigo() + " - " + P.GetNombre() + " - " + P.GetPrecio() + " - " + P.GetCategoria() + " - " + P.GetCantidad());
                    Console.WriteLine(" ");

                    listaProductos.Add(P);

                }


                else if (op == "2")
                {
                    Console.WriteLine("Ingrese el codigo del producto a borrar: ");
                    int borrado = int.Parse(Console.ReadLine());

                    foreach (var p in listaProductos)
                    {
                        if (p.GetCodigo() == borrado)
                        {
                            listaProductos.Remove(p);
                            break;
                        }
                    }
                    Console.WriteLine("Producto borrado con exito..!");
                    Console.WriteLine(" ");

                }
                

                else if(op == "3")
                {
                    Console.WriteLine("Lista de productos:");

                    foreach (var p in listaProductos)
                    {
                        Console.WriteLine(p.GetCodigo() + " - " + p.GetNombre() + " - " + p.GetPrecio() + " - " + p.GetCategoria() + " - " + p.GetCantidad());
                    }
                   Console.WriteLine(" ");

                }


                else if(op == "4")
                {
                    Console.WriteLine("Ingrese el codigo del producto: ");
                    string codigoVendido = Console.ReadLine();

                    Console.WriteLine("Ingrese cantidad: ");
                    int cantidadVendido = int.Parse(Console.ReadLine());                    
                    
                    Console.WriteLine("Ingrese medio de pago (credito o debito): ");
                    string medioPagoVendido = Console.ReadLine();

                    Console.WriteLine(" ");


                    foreach (var p in listaProductos)
                    {

                        if (p.GetCodigo() == int.Parse(codigoVendido))
                        {
                            String detalleVendido = p.GetNombre();
                            int totalVendido = cantidadVendido * p.GetPrecio();

                            Venta V = new Venta(cantidadVendido, detalleVendido, totalVendido, medioPagoVendido);
                            listaVentas.Add(V);
                            p.SetCantidad(p.GetCantidad() - V.GetCantidad());

                            Console.WriteLine("Venta exitosa..!");
                            Console.WriteLine(V.GetCantidad() + " - " + V.GetDetalle() + " - " + V.GetTotal() + " - " + V.GetMedioPago());
                            Console.WriteLine(" ");
                        }
                    }
                }


                else if(op == "5")
                {
                    Console.WriteLine("Lista de ventas:");

                    foreach (var v in listaVentas)
                    {
                        Console.WriteLine(v.GetCantidad() + " - " + v.GetDetalle() + " - " + v.GetTotal() + " - " + v.GetMedioPago());
                    }
                    Console.WriteLine(" ");

                }


                else if(op == "6")
                {
                    Console.WriteLine("Gracias por usar esta aplicacion..!");
                    Console.WriteLine(" ");

                }


            }//fin while

        }//fin método main

    }//fin class program

}//fin namespace PuntoDeVenta






