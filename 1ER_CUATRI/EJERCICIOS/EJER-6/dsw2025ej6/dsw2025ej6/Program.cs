using System.Globalization;
using System.Numerics;
using dsw2025ej6.Domino;


namespace dsw2025ej6;

internal class Program
{
    static void Main()
    {
        var producto = new Producto
        {
            CodigoProducto=532452,
            Descripcion="Yerba cachamate",
            PrecioVenta = 2000,
            Activo = true,
            Impuesto = 0.21f,
            Stock = 10,
            Presentacion = 'U',
            FechaAlta = DateTime.Now
        };

        producto.mostrarProducto();
        Console.WriteLine($"El precio sin impuesto es: {producto.mostrarPrecioSInImpuesto():C}");
        Console.WriteLine($"El stock es: {producto.Stock}");
        producto.aumentarStock(5);
        producto.decreceStock(0);
        producto.agregarStockPorc(30);

        Console.ReadKey();
    }

    
}
