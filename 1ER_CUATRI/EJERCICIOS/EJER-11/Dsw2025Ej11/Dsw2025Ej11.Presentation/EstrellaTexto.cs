namespace Dsw2025Ej11.Presentation;

internal class EstrellaTexto
{
    private int _x;
    private int _y;
    public EstrellaTexto()
    {
        
    }

    public void Ubicar(int x, int y)
    {
        _x = x;
        _y = y;
        Dibujar(ConsoleColor.White);
    }

    private void Dibujar(ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(_x, _y);
        Console.Write("*");
    }
}
