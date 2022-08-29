using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaDeBanco
{
    class Cuenta
    {
        public int numeroCuenta;
        public string rutTitular;
        public string rutBipersonal;
        public int passwordTitular;
        public int passwordBipersonal;
        private int saldoCuenta;


        public Cuenta(int numeroCuenta, string rutTitular, string rutBipersonal, int passwordTitular, int passwordBipersonal, int saldoCuenta)
        {
            this.numeroCuenta = numeroCuenta;
            this.rutTitular = rutTitular;
            this.rutBipersonal = rutBipersonal;
            this.passwordTitular = passwordTitular;
            this.passwordBipersonal = passwordBipersonal;
            this.saldoCuenta = saldoCuenta;

        }//fin constructor


        public int consultarSaldo()
        {
            return saldoCuenta;
        }


        public int depositar(int deposito)
        {
            this.saldoCuenta += deposito;

            return this.saldoCuenta;
        }


        public int girarDinero(int giro)
        {
            this.saldoCuenta -= giro;

            return this.saldoCuenta;
        }

    }//fin clase Cuenta

}//fin namespace CuentaDeBanco
