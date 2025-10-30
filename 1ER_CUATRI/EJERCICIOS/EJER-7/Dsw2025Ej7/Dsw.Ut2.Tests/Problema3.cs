using Dsw.Ut2.Code;
using Dsw.Ut2.Library;

namespace Dsw.Ut2.Test
{
    [TestClass]
    public partial class ProblemaTest3 : ProblemaTestBase<Problema3>
    {
        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            Iniciar();
        }

        [TestMethod]
        public void Test1()
        {
            Evaluar();
        }

        [TestMethod]
        public void Test2()
        {
            Evaluar();
        }

        [TestMethod]
        public void Test3()
        {
            Evaluar();
        }
        [TestMethod]
        public void Test4()
        {
            Evaluar();
        }
        [TestMethod]
        public void Test5()
        {
            Evaluar();
        }
    }
}
