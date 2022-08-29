using System;

namespace CuentaDeBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            UsuarioTitular Juan = new UsuarioTitular("Juan", "Perez", "17546812-2", "Las Dalias 1232, Ñuñoa", 987664333, 1234);

            UsuarioBipersonal Ana = new UsuarioBipersonal("Ana", "González", "16765678-2", "Las Dalias 1232, Ñuñoa", 987636433, 4321);

            Cuenta JuanConAna = new Cuenta(000123, "17546812-2", "16765678-2", 1234, 4321, 1000000);


            //Console.WriteLine($"nombre: {Juan.nombre} \napellido: {Juan.apellido} \nrut: {Juan.rut} \ndirección: {Juan.direccion} \ntelefono: {Juan.telefono} \npassword: {Juan.password}");
            //JuanConAna.saldoCuenta = 500000;
            //Console.WriteLine($"Saldo cuenta: {JuanConAna.saldoCuenta}");
            //Console.WriteLine(JuanConAna.consultarSaldo());


            Console.WriteLine("Ingrese su password: ");
            int passwordUsuarioCajero = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            string op = "0";


            while (op != "6")
            {
                Console.WriteLine("MENU CAJERO AUTOMÁTICO:");
                Console.WriteLine("");

                if(passwordUsuarioCajero == Juan.password || passwordUsuarioCajero == Ana.password)
                {
                    Console.WriteLine("1. Consultar Saldo");
                    Console.WriteLine("2. Hacer depósito");
                    Console.WriteLine("3. Hacer giro de dinero");
                    Console.WriteLine("4. Cambiar contraseña");
                    Console.WriteLine("5. Contratar productos");
                    Console.WriteLine("6. Salir");
                    Console.WriteLine("");
                    Console.WriteLine("Digite una opción: ");

                    op = Console.ReadLine();


                    if(op == "1")
                    {
                        Console.WriteLine($"Su saldo es: {JuanConAna.consultarSaldo()}");
                        Console.WriteLine(" ");
                    }

                    if(op == "2")
                    {
                        Console.WriteLine("Ingrese el monto a depositar: ");
                        int deposito = int.Parse(Console.ReadLine());

                        JuanConAna.depositar(deposito);

                        Console.WriteLine($"Su nuevo saldo es: {JuanConAna.consultarSaldo()}");
                        Console.WriteLine(" ");
                    }

                    if(op == "3")
                    {
                        Console.WriteLine("Ingrese el monto a girar: ");
                        int giro = int.Parse(Console.ReadLine());

                        JuanConAna.girarDinero(giro);

                        Console.WriteLine($"Su nuevo saldo es: {JuanConAna.consultarSaldo()}");
                        Console.WriteLine(" ");
                    }

                    if(op == "4")
                    {
                        if (passwordUsuarioCajero == 1234)
                        {
                            Console.WriteLine("Ingrese la nueva contraseña de 4 digitos: ");
                            int newPassword = int.Parse(Console.ReadLine());
                            passwordUsuarioCajero = newPassword;
                            Juan.cambiarContrasena(newPassword);

                            Console.WriteLine($"Su password fue modificado con éxito y ahora es: {Juan.password}");
                            Console.WriteLine(" ");


                        }
                        else if (passwordUsuarioCajero == 4321)
                        {
                            Console.WriteLine("Ingrese la nueva contraseña de 4 digitos: ");
                            int newPassword = int.Parse(Console.ReadLine());
                            passwordUsuarioCajero = newPassword;
                            Ana.cambiarContrasena(newPassword);

                            Console.WriteLine($"Su password fue modificado con éxito y ahora es: {Ana.password}");
                            Console.WriteLine(" ");

                        }
                    }

                    if(op == "5")
                    {
                        if(passwordUsuarioCajero == 1234)
                        {
                            Juan.contratarProductos();
                        }
                        else if(passwordUsuarioCajero == 4321)
                        {
                            Console.WriteLine("No tiene permiso para esta operación");
                            Console.WriteLine(" ");
                        }
                    }

                    if(op == "6")
                    {
                        Console.WriteLine("Gracias por usar este Cajero Automático, vuelva pronto..!");
                        Console.WriteLine(" ");
                    }


                }
                else
                {
                    Console.WriteLine("No tiene acceso a esta información");
                    Console.WriteLine(" ");
                }


            }//fin while menú

        }//fin método Main

    }//fin class Program

}//fin namespace CuentaDeBanco



