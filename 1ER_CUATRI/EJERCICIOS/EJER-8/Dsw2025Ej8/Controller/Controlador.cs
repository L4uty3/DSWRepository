using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Domain;

namespace Dsw2025Ej8.Controller
{
    internal class Controlador
    {
        private static List<Domain.CuentaBancaria> cuentas = Domain.Model.Cuentas;// Inicializar la lista de cuentas
        public static void Inicializar()
        {
            Model.Inicializar(); // Inicializar el modelo
            cuentas.AddRange(Model.Cuentas); // Agregar cuentas al controlador
        }

        public static void Depositar(string numero, decimal monto) 
        {
            try
            {
                var cuenta = cuentas.FirstOrDefault(c => c.Numero == numero);
                if (cuenta != null)
                {
                    cuenta.Depositar(monto);
                }
                else
                {
                    throw new CuentaNoEncontrada();
                }
            }
            catch (CuentaNoActiva ex){ Console.WriteLine(ex.Message); }
            catch (MontoNoValido ex) { Console.WriteLine(ex.Message); }
        }

        public static void Retirar(string numero, decimal monto)
        {
            try
            {
                var cuenta = Model.Cuentas.FirstOrDefault(c => c.Numero == numero);
                if (cuenta != null)
                {
                    cuenta.Retirar(monto);
                }
                else
                {
                    throw new CuentaNoEncontrada();
                    Console.ReadKey();
                }
            }
            catch (CuentaNoActiva ex){ Console.WriteLine(ex.Message); }
            catch (SaldoInsuficiente ex) { Console.WriteLine(ex.Message); }
            catch(MontoNoValido ex) { Console.WriteLine(ex.Message); }
        }
        */
        public static void ListarCuentas()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine($"{"Número",-15} {"Tipo",-20} {"Estado",-10} {"Saldo",10}");
            Console.WriteLine("---------------------------------------------------------------");
            foreach (var cuenta in Model.Cuentas)
            {
                   var resumen = new
                   {
                       numero = cuenta.Numero,
                       Titulares = (cuenta.Titulares),
                       Tipo = cuenta.Tipo,
                       Saldo = cuenta.Saldo,
                       Estado = cuenta.Estado
                   };
                Console.WriteLine($"{resumen.numero,-15} {resumen.Tipo,-20} {resumen.Estado,-15} {resumen.Saldo,10:C}");
            }
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}
