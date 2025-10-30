using Dsw2025Ej9.Bodegas;
using Dsw2025Ej9.Entidades;

namespace Dsw2025Ej9;

internal class Ejemplos
{
   /* public static void BodegaBasica()
    {
        //Había un barco con una única bodega donde se metía todo sin distinción: manzanas,
        //martillos o pantallas, todos encerrados en cajas genéricas (boxing).
        //Al llegar al puerto, cada caja había que abrirla y “unboxearla” (unboxing),
        //revisar su tipo y volverla a organizar a mano. Este proceso era lento, propenso a errores
        //(un martillo entre las manzanas) y no escalaba cuando llegaban nuevos productos.

        var bodega = new Basica();

        // 1) Almacenar referencias a Alimento y Herramienta
        bodega.Agregar(new Alimento("Manzana"));
        bodega.Agregar(new Herramienta("Martillo"));

        // 2) También podríamos agregar valores: ¡boxing automático!
        bodega.Agregar(42); // el int 42 se convierte a object

        Console.WriteLine("\nRecorriendo bodega (requiere comprobaciones y casteos):");
        foreach (object obj in bodega.Listar())
        {
            // Unboxing de int
            if (obj is int peso)
            {
                Console.WriteLine($"- Peso (unboxed): {peso} kg");
            }
            // Cast a clase Alimento
            else if (obj is Alimento alim)
            {
               // Console.WriteLine($"- Alimento: {alim.Nombre}");
            }
            // Cast a clase Herramienta
            else if (obj is Herramienta herr)
            {
                Console.WriteLine($"- Herramienta: {herr.Nombre}");
            }
            else
            {
                Console.WriteLine($"- Otro tipo: {obj.GetType().Name}");
            }
        }
    }

    public static void MultiBodegaTipada()
    {
        // Tras el caos de la única bodega, el capitán construyó tres independientes:
        // una para alimentos, otra para herramientas y la tercera para números enteros.
        // Cada bodega solo acepta su tipo, evitando casting incorrecto,
        // pero el código se repite para cada nueva clase de bodega.

        // Ahora cada bodega está fuertemente tipada
        var bAlimentos = new Alimentos();
        var bHerramientas = new Herramientas();
        var bEnteros = new Enteros();

        bAlimentos.Agregar(new Alimento("Manzana"));
        bHerramientas.Agregar(new Herramienta("Martillo"));
        bEnteros.Agregar(43);
        
        Console.WriteLine("\nRecorriendo bodegas múltiples:");
        Console.WriteLine("\n--- Contenido Alimentos ---");
        foreach (Alimento a in bAlimentos.Listar())
        //    Console.WriteLine($"- {a.Nombre}");

        Console.WriteLine("\n--- Contenido Herramientas ---");
        foreach (Herramienta h in bHerramientas.Listar())
            Console.WriteLine($"- {h.Nombre}");

        Console.WriteLine("\n--- Contenido Enteros ---");
        foreach (int e in bEnteros.Listar())
            Console.WriteLine($"- {e}");
    }
    */
    public static void BodegaGenerica()
    {
        var bAlimento = new Generica<Alimento>();
        var bHerramienta = new Generica<Herramienta>();
        var bProductoElectronico = new Generica<ProductoElectronico>();

        bAlimento.Añadir(new Alimento("Manzana"));
        bAlimento.Añadir(new Alimento("Pera"));

        bHerramienta.Añadir(new Herramienta("Martillo"));
        bHerramienta.Añadir(new Herramienta("Tadralo",true));

        bProductoElectronico.Añadir(new ProductoElectronico("Televisor","Hisense"));
        bProductoElectronico.Añadir(new ProductoElectronico("Celular", "Samsung"));

        Listar(bAlimento.Listar());
        Listar(bHerramienta.Listar());
        Listar(bProductoElectronico.Listar());

        void Listar<T>(List<T> lista) where T : Mercancia
        {
            Console.WriteLine($"\n{lista.GetType}");
            foreach (var item in lista)
            {
                Console.WriteLine($"- {item.Nombre}");
            }
        }
        Console.ReadKey();
    }
}
