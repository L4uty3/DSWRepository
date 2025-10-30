namespace Dsw2025Ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productos = Producto.CrearListaDeEjemplo();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Primer producto");
            Console.WriteLine("2. Último producto");
            Console.WriteLine("3. Suma de precios");
            Console.WriteLine("4. Promedio de precios");
            Console.WriteLine("5. Productos con Id mayor a 15");
            Console.WriteLine("6. Productos con nombre y precio en formato moneda");
            Console.WriteLine("7. Producto con el precio más alto");
            Console.WriteLine("8. Producto con el precio más bajo");
            Console.WriteLine("9. Productos con precio mayor al promedio");
            Console.WriteLine("10. Productos ordenados por descripción de forma descendente");
            Console.WriteLine("0. Salir");
            int opcion;

            do
            {
                Console.Write("Ingrese su opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Solucion.PrimerProducto(productos);
                        break;
                    case 2:
                        Solucion.UltimoProducto(productos);
                        break;
                    case 3:
                        Solucion.SumaDePrecios(productos);
                        break;
                    case 4:
                        Solucion.PromedioDePrecios(productos);
                        break;
                    case 5:
                        Solucion.ProductosConIdMayorA15(productos);
                        break;
                    case 6:
                        Solucion.ProductosConNombreYPrecioEnFormatoMoneda(productos);
                        break;
                    case 7:
                        Solucion.ProductoConPrecioMasAlto(productos);
                        break;
                    case 8:
                        Solucion.ProductoConPrecioMasBajo(productos);
                        break;
                    case 9:
                        Solucion.ProductosConPrecioMayorAlPromedio(productos);
                        break;
                    case 10:
                        Solucion.ProductosOrdenadosPorDescripcionDescendente(productos);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            } while (opcion != 0);

            /* A partir de la lista de productos que se obtiene de Producto.CrearListaDeEjemplo()
             * Resolver:
             * 1. El primer producto 
             * 2. El último producto
             * 3. La suma de precios
             * 4. El promedio de precios
             * 5. Listar los productos con Id mayor a 15
             * 6. Obtener una lista de cada producto con su nombre y el precio en formato moneda, luego mostrar los elementos
             * 7. El producto con el precio más alto
             * 8. El producto con el precio más bajo
             * 9. Obtener y mostrar los productos cuyo precio sea mayor al promedio
             * 10. Listar los productos ordenados por descripción de forma descendente
             * Cada punto se debe realizar en un método distinto, en una nueva clase llamada Solucion
             */

        }
    }
}
