using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class CalculadoraBasica
    {
        private int num1;
        private int num2;

        public CalculadoraBasica(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }


        public int GetNum1()
        {
            return this.num1;
        }

        public int GetNum2()
        {
            return this.num2;
        }


        public void SetNum1(int primerNumero)
        {
            this.num1 = primerNumero;
                     
        }

        public void SetNum2(int segundoNumero)
        {
            this.num2 = segundoNumero;

        }


        public int HacerSuma(int numero1, int numero2)
        {
            return (numero1 + numero2);
        }

        public int HacerResta(int numero1, int numero2)
        {
            return (numero1 - numero2);
        }

        public int HacerMultiplicacion(int numero1, int numero2)
        {
            return (numero1 * numero2);
        }

        public int HacerDivision(int numero1, int numero2)
        {
            return (numero1 / numero2);
        }


    }//fin class CalculadoraBasica

}//fin namespace Calculadora
