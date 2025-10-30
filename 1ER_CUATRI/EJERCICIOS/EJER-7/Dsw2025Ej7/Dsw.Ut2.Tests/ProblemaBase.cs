using Dsw.Ut2.Code;
using Dsw.Ut2.Library;

namespace Dsw.Ut2.Test
{
    [TestClass]
    public partial class ProblemasTest : EnsambladoTestBase
    {
        [AssemblyInitialize]
        public static void Initialize(TestContext context)
        {
            IniciarGeneral(typeof(Datos), Datos.Host);
        }

        [TestCleanup]
        public void TestCleanup()
        {

        }

        [ClassCleanup]
        public static void Cleanup()
        {

        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            
        }
    }
}
