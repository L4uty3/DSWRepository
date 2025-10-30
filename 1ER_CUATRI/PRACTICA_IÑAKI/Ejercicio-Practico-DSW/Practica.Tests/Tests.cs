namespace Practica.Tests
{
    [TestClass]
    private class Tests
    {
        [TestMethod]
        public void Test1()
        {
            var procesador = new ProcesadorDeEnteros();
            var datos = new List<int> { 1, 2, 3, 4, 5, 6 };
            int resultado = procesador.Procesar(datos, x => x % 2 == 0);
            Assert.AreEqual(12, resultado);
        }

        [TestMethod]
        public void Test2()
        {
            var procesador = new ProcesadorDeStrings();
            var datos = new List<string> { "uno", "dos", "tres", "cuatro", "cinco", "doce" };
            var resultado = procesador.Procesar(datos, s => s.Contains('o'));
            Assert.AreEqual("cuatro", resultado);
        }

        [TestMethod]
        public void Test3()
        {
            var numeros = new List<int> { 4, 8, 15, 16, 23, 42 };
            var (min, max, promedio) = Estadisticas.CalcularEstadisticas(numeros);
            Assert.AreEqual(4, min);
            Assert.AreEqual(42, max);
            Assert.AreEqual(18, promedio, 0.01);
        }

        [TestMethod]
        public void Test4()
        {
            var palabras = new List<string> { "HOLA", "mundo", "CSharp", "API", "dotNET" };
            var resultado = palabras.SoloMayusculas().ToList();
            CollectionAssert.AreEqual(new List<string> { "HOLA", "API" }, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DatosInvalidoasException))]
        public void Test5()
        {
            var procesador = new ProcesadorDeEnteros();
            var resultado = procesador.Procesar([], x => true);
        }

        [TestMethod]
        [ExpectedException(typeof(DatosInvalidosException))]
        public void Test6()
        {
            var resultado = Estadisticas.CalcularEstadisticas([]);
        }

        [TestMethod]
        public void Test7()
        {
            var proc = new ProcesadorDeEnteros();
            int resultado = proc.Procesar(new[] { 1, 2, 3 }, x => x == 2);
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void Test8()
        {
            var proc = new ProcesadorDeEnteros();
            int resultado = proc.Procesar(new[] { 1, 2, 3 }, x => x > 10);
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Test9()
        {
            var proc = new ProcesadorDeStrings();
            string resultado = proc.Procesar(new[] { "uno", "tres", "cinco" }, x => true);
            Assert.AreEqual("cinco", resultado);
        }

        [TestMethod]
        public void Test10()
        {
            var proc = new ProcesadorDeStrrings();
            string resultado = proc.Procesar(new[] { "hola", "esto es largo", "corto" }, x => x.Contains(" "));
            Assert.AreEqual("esto es largo", resultado);
        }

        [TestMethod]
        public void Test11()
        {
            var result = Estadisticas.CalcularEstadisticas(new[] { -10, -5, 0, 5, 10 });
            Assert.AreEqual(-10, result.min);
            Assert.AreEqual(10, result.max);
            Assert.AreEqual(0, result.promedio, 0.001);
        }

        [TestMethod]
        public void Test12()
        {
            var result = Estadisticas.CalcularEstadisticas(new[] { 42 });
            Assert.AreEqual(42, result.min);
            Assert.AreEqual(42, result.max);
            Assert.AreEqual(42.0, result.promedio);
        }

        [TestMethod]
        public void Test13()
        {
            var lista = new[] { "HOLA", "mundo", "BUENOS DIAS", "buenas noches" };
            var resultado = lista.SoloMayusculas().ToList();
            CollectionAssert.AreEquivalent(new[] { "HOLA", "BUENOS DIAS" }, resultado);
        }

        [TestMethod]
        public void Test14()
        {
            var lista = new string[0];
            var resultado = lista.SoloMayusculas();
            Assert.IsFalse(resultado.Any());
        }

        [TestMethod]
        public void Test15()
        {
            var lista = new[] { "hola", "mundo", "buen dia" };
            var resultado = lista.SoloMayusculas();
            Assert.IsFalse(resultado.Any());
        }

        [TestMethod]
        public void Test16()
        {
            var proc = new ProcesadorDeStrings();
            string resultado = proc.Procesar(["hola", null, "chauuuu", null], x => x != null && x.Contains('u'));
            Assert.AreEqual("chauuuu", resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DatosInvalidosException))]
        public void Test17()
        {
            var proc = new ProcesadorDeStrings();
            var resultado = proc.Procesar(null, a => a.StartsWith('a'));
        }

        [TestMethod]
        [ExpectedException(typeof(DatosInvalidosException))]
        public void Test18()
        {
            var proc = new ProcesadorDeEnteros();
            var resultado = proc.Procesar(null, a => a == 5);
        }

        [TestMethod]
        public void Test19()
        {
            var procesador = new ProcesadorDeStrings();
            var datos = new List<string> { "uno", "dos", "tres", "cuatro", "cinco", "doce", "sentao" };
            var resultado = procesador.Procesar(datos, s => s.Contains('o'));
            Assert.AreEqual("cuatro", resultado);
        }

        [TestMethod]
        public void Test20()
        {
            var procesador = new ProcesadorDeStrings();
            var datos = new List<string> { "uno", "dos", "tres", "cuatro", "cinco", "doce", "sentao" };
            var resultado = procesador.Procesar(datos, s => s.Contains('x'));
            Assert.AreEqual(null, resultado);
        }

        [TestMethod]
        public void Test21()
        {
            var procesador = new ProcesadorDeEnteros();
            var datos = new List<int> { 1, 2, 3, 4, 5, 6 };
            var resultado = procesador.Procesar(datos, s => s == 10);
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Test22()
        {
            var lista = new[] { "a", "b", "ccc", "d" };
            var resultado = lista.SoloMayusculas().ToList();
            Assert.IsTrue(resultado.Count == 0);
        }
    }
}

























}
