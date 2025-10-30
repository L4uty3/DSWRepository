namespace Dsw2025Ej11.Presentation;

internal class VistaPrincipal
{

    public static void Iniciar()
    {
        Console.Title = "La Constelación";
        Console.SetWindowSize(140, 50); // Cambia el tamaño de la ventana de la consola
        DibujarBordes(Console.WindowWidth, Console.WindowHeight);
        Console.SetCursorPosition(2, 48);
        Console.WriteLine("[A] Agregar una estrella | [S] Salir");
        Console.CursorVisible = false; // Oculta el cursor
        ConsoleKeyInfo key = new ConsoleKeyInfo();
        do
        {
            key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.A)
            {
                DibujarEstrella();
            }
        }
        while (key.Key != ConsoleKey.S);
    }

    static void DibujarEstrella()
    {
        Console.SetCursorPosition(0,0); // Mueve el cursor a la posición (0, 0)
        Random random = new Random();
        var w = random.Next(3, 138);
        var h = random.Next(3, 46);
        var estrella = new EstrellaTexto();
        estrella.Ubicar(w, h);
        Console.SetCursorPosition(2, 48);
    }

    static void DibujarBordes(int width, int height)
    {
        if (width < 2 || height < 2)
        {
            Console.WriteLine("El ancho y alto deben ser al menos 2.");
            return;
        }

        // Línea superior
        Console.Write("┌");
        Console.Write(new string('─', width - 2));
        Console.WriteLine("┐");

        // Líneas intermedias
        for (int i = 0; i < height - 4; i++)
        {
            Console.Write("│");
            Console.Write(new string(' ', width - 2));
            Console.WriteLine("│");
        }

        // Línea inferior
        Console.Write("└");
        Console.Write(new string('─', width - 2));
        Console.WriteLine("┘");
    }
}
