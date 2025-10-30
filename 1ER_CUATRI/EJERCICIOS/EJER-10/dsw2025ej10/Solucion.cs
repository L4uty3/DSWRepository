using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej10
{
    public class Solucion
    {
        public static void PrimerProducto(List<Producto> productos)
        {
            var primerProducto = productos.First();
            Console.WriteLine($"Primer producto: {primerProducto}");
        }

        public static void UltimoProducto(List<Producto> productos)
        {
            var ultimoProducto = productos.Last();
            Console.WriteLine($"Último producto: {ultimoProducto}");
        }

        public static void SumaDePrecios(List<Producto> productos)
        {
            var sumaPrecios = productos.Sum(p => p.Precio);
            Console.WriteLine($"Suma de precios: {sumaPrecios:C}");
        }

        public static void PromedioDePrecios(List<Producto> productos)
        {
            var promedioPrecios = productos.Average(p => p.Precio);
            Console.WriteLine($"Promedio de precios: {promedioPrecios:C}");
        }

        public static void ProductosConIdMayorA15(List<Producto> productos)
        {
            var productosFiltrados = productos.Where(p => p.Id > 15).ToList();
            Console.WriteLine("Productos con Id mayor a 15:");
            Console.WriteLine(string.Join(Environment.NewLine, productosFiltrados));
        }


        public static void ProductosConNombreYPrecioEnFormatoMoneda(List<Producto> productos)
        {
            var listaFormateada = productos.Select(p => $"{p.Descripcion}: {p.Precio:C}").ToList();
            Console.WriteLine("Productos con nombre y precio en formato moneda:");
            Console.WriteLine(string.Join(Environment.NewLine, listaFormateada));
        }

        public static void ProductoConPrecioMasAlto(List<Producto> productos)
        {
            var productoMasCaro = productos.Max(p => p.Precio);
            Console.WriteLine($"Producto con el precio más alto: {productoMasCaro}");
        }

        public static void ProductoConPrecioMasBajo(List<Producto> productos)
        {
            var productoMasBarato = productos.Min(p => p.Precio);
            Console.WriteLine($"Producto con el precio más bajo: {productoMasBarato}");
        }

        public static void ProductosConPrecioMayorAlPromedio(List<Producto> productos)
        {
            var promedioPrecios = productos.Average(p => p.Precio);
            var productosFiltrados = productos.Where(p => p.Precio > promedioPrecios).ToList();
        }

        public static void ProductosOrdenadosPorDescripcionDescendente(List<Producto> productos)
        {
            var productosOrdenados = productos.OrderByDescending(p => p.Descripcion).ToList();
            Console.WriteLine("Productos ordenados por descripción de forma descendente:");
            Console.WriteLine(string.Join(Environment.NewLine, productosOrdenados));
        }
    }
}
