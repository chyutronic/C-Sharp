using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CalculadoraCientifica miCalculadora = new CalculadoraCientifica(0, 0);

            string op = "0";


            while (op != "7")
            {
                Console.WriteLine("CALCULADORA");
                Console.WriteLine("Cuál operación desea realizar..?");
                Console.WriteLine("");

                Console.WriteLine("1. SUMAR");
                Console.WriteLine("2. RESTAR");
                Console.WriteLine("3. MULTIPLICAR");
                Console.WriteLine("4. DIVIDIR");
                Console.WriteLine("5. RAIZ CUADRADA");
                Console.WriteLine("6. POTENCIA");
                Console.WriteLine("7. Salir");
                Console.WriteLine("");

                Console.WriteLine("Digite una opción: ");
                op = Console.ReadLine();


                if (op == "1")
                {
                    Console.WriteLine("Ingrese el primer número: ");
                    int primerNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum1(primerNumero);

                    Console.WriteLine("Ingrese el segundo número: ");
                    int segundoNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum2(segundoNumero);

                    int suma = miCalculadora.HacerSuma(primerNumero, segundoNumero);
                    Console.WriteLine($"El resultado es: {suma}");
                    Console.WriteLine("");

                }
                if(op == "2")
                {
                    Console.WriteLine("Ingrese el primer número: ");
                    int primerNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum1(primerNumero);

                    Console.WriteLine("Ingrese el segundo número: ");
                    int segundoNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum2(segundoNumero);

                    int resta = miCalculadora.HacerResta(primerNumero, segundoNumero);
                    Console.WriteLine($"El resultado es: {resta}");
                    Console.WriteLine("");

                }
                if(op == "3")
                {
                    Console.WriteLine("Ingrese el primer número: ");
                    int primerNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum1(primerNumero);

                    Console.WriteLine("Ingrese el segundo número: ");
                    int segundoNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum2(segundoNumero);

                    int multiplicacion = miCalculadora.HacerMultiplicacion(primerNumero, segundoNumero);
                    Console.WriteLine($"El resultado es: {multiplicacion}");
                    Console.WriteLine("");

                }
                if(op == "4")
                {
                    Console.WriteLine("Ingrese el primer número: ");
                    int primerNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum1(primerNumero);

                    Console.WriteLine("Ingrese el segundo número: ");
                    int segundoNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum2(segundoNumero);

                    int division = miCalculadora.HacerDivision(primerNumero, segundoNumero);
                    Console.WriteLine($"El resultado es: {division}");
                    Console.WriteLine("");

                }
                if (op == "5")
                {
                    Console.WriteLine("Ingrese el número para calcular su raiz cuadrada: ");
                    int primerNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum1(primerNumero);

                    double raizCuadrada = miCalculadora.SacarRaizCuadrada(miCalculadora.GetNum1());
                    Console.WriteLine($"El resultado es: {raizCuadrada}");
                    Console.WriteLine("");

                }
                if (op == "6")
                {
                    Console.WriteLine("Ingrese el número de la base: ");
                    int primerNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum1(primerNumero);

                    Console.WriteLine("Ingrese el número del exponente: ");
                    int segundoNumero = int.Parse(Console.ReadLine());
                    miCalculadora.SetNum2(segundoNumero);

                    double potencia = miCalculadora.ObtenerPotencia(miCalculadora.GetNum1(), miCalculadora.GetNum2());
                    Console.WriteLine($"El resultado es: {potencia}");
                    Console.WriteLine("");

                }
                if (op == "7")
                {

                    Console.WriteLine("Gracias por usar esta aplicación..!");
                    Console.WriteLine("");
                    Console.ReadLine();

                }

            }// fin while

        }// fin método main

    }// fin class Program

}// fin namespace Calculadora
