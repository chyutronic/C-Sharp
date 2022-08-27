// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;

namespace BoletaHonorarios
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("En qué año estamos..?: ");
            string ano = Console.ReadLine();            
            
            Console.WriteLine("Vas a introducir un valor liquido(l) o bruto(b)..?: ");
            string tipoBoleta = Console.ReadLine();

            double retencion2022 = 12.25;
            int retencion2023 = 13;
            double retencion2024 = 13.75;
            double retencion2025 = 14.5;
            double retencion2026 = 15.25;
            int retencion2027 = 16;
            int retencion2028 = 17;


            if ("l" == tipoBoleta)
            {
                Console.WriteLine("Introduce el valor liquido: ");
                string strLiquido = Console.ReadLine();

                double liquido = Convert.ToDouble(strLiquido);
                double valorBruto;


                if (null == ano)
                {
                    valorBruto = ((liquido * 100) / (100 - retencion2028));
                }

                else switch(ano)
                {
                    case "2022":
                        valorBruto = (liquido * 100) / (100 - retencion2022);
                        break;                   
                    case "2023":
                        valorBruto = (liquido * 100) / (100 - retencion2023);
                        break;
                    case "2024":
                        valorBruto = (liquido * 100) / (100 - retencion2024);
                        break;
                    case "2025":
                        valorBruto = (liquido * 100) / (100 - retencion2025);
                        break;
                    case "2026":
                        valorBruto = (liquido * 100) / (100 - retencion2026);
                        break;
                    case "2027":
                        valorBruto = (liquido * 100) / (100 - retencion2027);
                        break;
                    case "2028":
                        valorBruto = (liquido * 100) / (100 - retencion2028);
                        break;
                    default:
                        valorBruto = (liquido * 100) / (100 - retencion2028);
                        break;

                };

                Console.WriteLine($"El valor bruto de la Boleta de Honorarios es: {Math.Floor(valorBruto)}");
                Console.WriteLine(" ");
            }

            if ("b" == tipoBoleta)
            {
                Console.WriteLine("Introduce el valor bruto: ");
                string strBruto = Console.ReadLine();

                double bruto = Convert.ToDouble(strBruto);
                double valorLiquido;

                if (null == ano)
                {
                    valorLiquido = ((bruto * (100 - retencion2028)) / 100);
                }

                else switch (ano)
                {
                    case "2022":
                        valorLiquido = (bruto * (100 - retencion2022)) / 100;
                        break;                    
                    case "2023":
                        valorLiquido = (bruto * (100 - retencion2023)) / 100;
                        break;
                    case "2024":
                        valorLiquido = (bruto * (100 - retencion2024)) / 100;
                        break;
                    case "2025":
                        valorLiquido = (bruto * (100 - retencion2025)) / 100;
                        break;
                    case "2026":
                        valorLiquido = (bruto * (100 - retencion2026)) / 100;
                        break;
                    case "2027":
                        valorLiquido = (bruto * (100 - retencion2027)) / 100;
                        break;
                    case "2028":
                        valorLiquido = (bruto * (100 - retencion2028)) / 100;
                        break;
                    default:
                        valorLiquido = (bruto * (100 - retencion2028)) / 100;
                        break;

                };

                Console.WriteLine($"El valor líquido de la Boleta de Honorarios es: {Math.Floor(valorLiquido)}");
                Console.WriteLine(" ");
            }

        }//fin método main

    }//fin class program

}//fin namespace PuntoDeVenta

