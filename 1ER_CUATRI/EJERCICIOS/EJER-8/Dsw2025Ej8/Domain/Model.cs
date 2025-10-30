using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej8.Domain
{
    public static class Model
    {
        public static List<CuentaBancaria> Cuentas { get; } = new List<CuentaBancaria>();
        public static void Inicializar()
        {
            Cuentas.Clear();
            Cuentas.Add(new CajaAhorro("1", 12000, TipoCuenta.CajaDeAhorro, new string[] { "Juan Perez" }));
            Cuentas.Add(new CajaAhorro("2", 2000, TipoCuenta.CajaDeAhorro, new string[] { "Carlos Garcia" }));
            Cuentas.Add(new CuentaCorriente("3", 5000, TipoCuenta.CuentaCorriente, new string[] { "Maria Lopez" }));         
            Cuentas.Add(new CuentaCorriente("4", 1500, TipoCuenta.CuentaCorriente, new string[] { "Ana Martinez" }));
        }
       
    }
}
