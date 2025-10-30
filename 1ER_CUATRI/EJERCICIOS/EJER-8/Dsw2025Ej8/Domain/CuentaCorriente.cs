using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    internal class CuentaCorriente : CuentaBancaria
    {
        public CuentaCorriente(string numero, decimal saldo, TipoCuenta tipo, string[] titulares) : base(numero, saldo, tipo, titulares)
        {
        }
        public override void Depositar(decimal monto)
        {
            Saldo += monto;
        }
        public override void Retirar(decimal monto)
        {
            if (Saldo - monto >= -LimiteDeDescubierto)
            {
                Saldo -= monto;
                Console.WriteLine($"Retiro exitoso. Quedan ${Saldo} en la cuenta");
            }
            else
            {
                throw new InvalidOperationException("Fondos insuficientes o límite de descubierto alcanzado.");
            }
        }
    }
}
