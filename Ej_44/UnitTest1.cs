using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej_41;



namespace Ej_44
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListaCreada()
        {
            Centralita centralita = new Centralita();

            //assert
            Assert.IsNotNull(centralita.Llamadas);
            Assert.IsInstanceOfType(centralita.Llamadas, typeof(System.Collections.Generic.List<Llamada>));
        }
    }
}
