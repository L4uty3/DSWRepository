// DSW - Ejercicio de práctica

/*
Temas a tratar en el ejercicio:
 - Delegados y expresiones lambda
 - Manejo de excepciones
 - LINQ
 - Tuplas
 - Genéricos
 - Clases estáticas y métodos de extensión
 - Interfaces
 - Programación orientada a objetos

La resolución será probada en múltiples tests, se pueden ver desde Test Explorer una vez solucionados los problemas de la solución
No modificar los tests
Leer la consigna completa antes de empezar

INSTRUCCIONES:

1. Crear la interfaz IProcesador<T>:
   - Debe contener un método llamado Procesar.
   - El método debe retornar el mismo tipo T.
   - Debe recibir dos parámetros:
       * Un IEnumerable<T>
       * Un delegado que reciba T y devuelva bool

2. Crear la clase ProcesadorDeEnteros:
   - Debe implementar la interfaz IProcesador para enteros
   - El método Procesar debe filtrar los datos usando el delegado y retornar la suma de los elementos válidos
   - Si la lista está vacía, lanzar la excepción DatosInvalidosException
   - Si no se cumple la condición, retornar cero

3. Crear la clase ProcesadorDeStrings:
   - Debe implementar la interfaz IProcesador<string>
   - El método Procesar debe retornar el string más largo que cumpla la condición
   - Si más de un string cumple la condición, retornar el primero
   - Si la lista está vacía, lanzar la excepción DatosInvalidosException
   - Si no hay strings que cumplan la condición, retornar null

4. Crear la clase estática Estadisticas:
   - Agregar el método CalcularEstadisticas, que reciba un IEnumerable<int>
   - Debe retornar tres valores: Dos enteros, que representan el mínimo y el máximo, y un double, que es el promedio
   - Si la lista está vacía, lanzar DatosInvalidosException

5. Crear la clase DatosInvalidosException:
   - Debe heredar de Exception y permitir pasar un mensaje por constructor

6. Crear una clase estática Extensiones:
   - Agregar un método de extensión llamado SoloMayusculas para IEnumerable<string>
   - El método debe retornar sólo los strings que estén completamente en mayúsculas
   - Si ninguno cumple la condición, retornar una colección vacía

Tener en cuenta que, ante la necesidad de trabajar con cualquier colección, siempre la primera opción es usar LINQ

            TRABAJAR SIEMPRE DENTRO DEL PROYECTO "Practica", Y EN UN NAMESPACE LLAMADO "Practica"
*/
