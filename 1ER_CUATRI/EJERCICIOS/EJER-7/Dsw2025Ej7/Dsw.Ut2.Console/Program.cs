using Dsw.Ut2.Library;

namespace Dsw.Ut2.Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DswUt2Manager.Iniciar(typeof(Datos), Datos.Host);
        }
    }
}
