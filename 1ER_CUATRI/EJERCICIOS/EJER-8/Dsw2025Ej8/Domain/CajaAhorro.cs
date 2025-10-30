using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class CajaAhorro : CuentaBancaria
    {
        public CajaAhorro(string numero, decimal saldo, TipoCuenta tipo, string[] titulares)
            :base(numero, saldo, tipo, titulares)
        {
            // Constructor de la clase CajaAhorro
        }

        public override void Depositar(decimal monto)
        {
            Saldo += monto;
        }

        public override void Retirar(decimal monto)
        {
            if (Saldo - monto >= 0)
            {
                Saldo -= monto;
                Console.WriteLine($"Retiro exitoso. Quedan ${Saldo} en la cuenta");
            }
            else
            {
                
            }
        }
    }
}
