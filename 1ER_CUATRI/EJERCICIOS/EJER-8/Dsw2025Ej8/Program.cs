namespace Dsw2025Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Domain.Model.Inicializar(); // Inicializar el controlador
            Views.Menu.Run(); // Ejecutar el menú
        }
    }
}
