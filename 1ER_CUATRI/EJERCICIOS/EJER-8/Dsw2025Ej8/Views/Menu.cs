using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dsw2025Ej8.Controller;



namespace Dsw2025Ej8.Views
{
    internal static class Menu
    {
        public static void Run()
        {
            int option;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al sistema de cuentas bancarias");
                Console.WriteLine("1. DEPOSITO");
                Console.WriteLine("2. RETIRO");
                Console.WriteLine("3. LISTAR CUENTAS");
                Console.WriteLine("0. SALIR");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Opción no válida, intente nuevamente.");
                    continue;
                }
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("|---------------------REALIZAR DEPÓSITO---------------------|");
                        Console.WriteLine(">Ingresar Número de Cuenta: "); // Solicitar el número de cuenta
                        string number = Console.ReadLine(); // Leer el número de cuenta
                        Console.WriteLine(">Ingresar Monto a Depositar: ");
                        decimal monto = Convert.ToDecimal(Console.ReadLine());
                        Console.Clear();
                        Controller.Controlador.Depositar(number, monto);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("|---------------------REALIZAR RETIRO---------------------|");
                        Console.WriteLine(">Ingresar Número de Cuenta: "); // Solicitar el número de cuenta
                        number = Console.ReadLine(); // Leer el número de cuenta
                        Console.WriteLine(">Ingresar Monto a Retirar: ");
                        monto = Convert.ToDecimal(Console.ReadLine());
                        Console.Clear();
                        Controller.Controlador.Retirar(number, monto);
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("|---------------------LISTAR CUENTAS---------------------|");
                        Controlador.ListarCuentas();
                        Console.ReadKey();
                        break;

                    case 0:
                        Console.Clear();
                        Console.Write("Saliendo del sistema");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(600);
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;

                }
            } while (option != 0);
        }
    }
}
