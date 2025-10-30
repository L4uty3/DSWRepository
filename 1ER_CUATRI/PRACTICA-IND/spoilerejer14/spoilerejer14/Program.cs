using System.ComponentModel;

namespace spoilerejer14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection.AddSingleton<Domain.Product>();
        }
    }
}
