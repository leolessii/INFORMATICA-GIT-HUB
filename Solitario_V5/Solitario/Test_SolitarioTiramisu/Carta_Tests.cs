using Classi_SolitarioTiramisu;
using System.Net.Http.Headers;
using System.Security.Principal;

namespace Test_SolitarioTiramisu
{
    [TestClass]
    public class Carta_Tests
    {
        [TestMethod]
        public void ControlloValoreCarta()
        {
            Assert.ThrowsException<ArgumentException>(() => { Carta c = new Carta((Seme)3, (Valore)20); });
        }

        [TestMethod]
        public void ControlloSemeCarta()
        {
            Assert.ThrowsException<ArgumentException>(() => { Carta c = new Carta((Seme)12, Valore.tre); });
        }

        [TestMethod]
        public void ControlloEquals()
        {
            Carta c1 = new Carta(Seme.A , Valore.sei);
            Carta c2 = new Carta(Seme.A , Valore.tre);

            Assert.IsTrue(c1.Equals(c2));
        }
    }
}