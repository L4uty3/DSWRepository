using Dsw2025Ej9.Entidades;

namespace Dsw2025Ej9.Bodegas;

/*
     * ¡Se decidió construir una bodega por cada tipo!
     * Después de hartarse de añadir BodegaAlimentos, BodegaHerramientas,
     * BodegaElectronica, los marineros descubrieron que podían tener
     * una única bodega que funcione con cualquier mercancía.
     *
     * TU MISIÓN:
     * 1) Crear una clase genérica, con los métodos que debería tener una bodega
     
     * 2) Completar el método EjemploBodegasGenericas (en la clase Ejemplos):
     *      – Instanciar diferentes bodegas, para cada tipo de mercancía.
     *      – Agregar al menos dos elementos de cada tipo.
     *      – Listar y mostrar por consola el contenido de cada bodega.
     *      
     * 3) Asegurar que la nueva bodega genérica solo acepte mercancías
     *
     */
public class Generica<T> where T: Mercancia
{
    private readonly List<T> lista = new List<T>(); 

    public void Añadir(T item)
    {
        lista.Add(item);  // Añadir el elemento a la bodega
    }
    
    public T Obtener(int index)
    {
        // Devolver el elemento en la posición indicada
        if (lista.Count==0 || index >= lista.Count)
            throw new Exception("no hay nada en la bodega");
        return lista[index];
    }
    public List<T> Listar()
    {
        // Devolver el contenido de la bodega
        return lista;
    }
}
