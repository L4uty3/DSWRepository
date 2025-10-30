using System.Runtime.InteropServices;

namespace ConsoleApp1;

public delegate void Notificador(string mensajes);

internal class Program
{

    static void Main()
    {
        Caja<string>.ProbarGenerico();
        Console.ReadKey();
    }

    public class Caja<T>
    {
        public int? Contenido { get; private set; }
        public Caja(T contenido)
        {
            Contenido = contenido as int?;
            Contenido = contenido as string != null ? null : Contenido;
        }

        public static void ProbarGenerico()
        {
            var cajaInt = new Caja<int>(42);
            var cajaString = new Caja<string>("Hola");
            Console.WriteLine($"{cajaInt.Contenido} - "+
                $"{cajaString.Contenido}");
        }
    }
    /*public delegate void Operacion(int a, int b);
    public static void sumar(int a, int b)
    {
        Console.WriteLine($"La suma es: {a + b}");
    }
    public static void restar(int a, int b)
    {
        Console.WriteLine($"La resta es: {a - b}");
    }
    static void Main(string[] args)
    {
        Operacion op = sumar;
        op += restar;
        op(15, 5);
        Console.ReadKey();
    }
    */


    /* static void Main()
     {

         Notificador n = MostrarEnMayusculas;
         n += msg => Console.WriteLine($"mensaje:  {msg}");
         n("Hola Mundo");
         Console.ReadKey();
     }

     static void MostrarEnMayusculas(string texto)
     {
         Console.WriteLine(texto.ToUpper());
     }*/
}
