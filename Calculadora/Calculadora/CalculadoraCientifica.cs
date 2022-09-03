using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class CalculadoraCientifica : CalculadoraBasica
    {
        public CalculadoraCientifica(int num1, int num2) : base(num1, num2)
        {

        }



        public double SacarRaizCuadrada(int numeroRaiz)
        {
            double raiz = Math.Sqrt(numeroRaiz);

            return raiz;
        }


        public double ObtenerPotencia(int numBase, int numExponente)
        {
            double potencia = Math.Pow(numBase, numExponente);

            return potencia;
        }

       

    }//fin class CalculadoraCientifica

}//fin namespace Calculadora
