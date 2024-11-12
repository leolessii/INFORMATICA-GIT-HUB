using Classi_SolitarioTiramisu;

namespace Test_SolitarioTiramisu
{
    [TestClass]
    public class Mazzetto_Tests
    {
        [TestMethod]
        public void ControlloAggiungiCarta()
        {
            Carta carta = new Carta(Seme.B , Valore.otto);

            Mazzetto m = new Mazzetto();

            m.AggiungiCarta(carta);

            Assert.AreEqual(m.Carte[m.Carte.Count - 1], carta);
        }

        [TestMethod]
        public void ControlloRimozioneCarta()
        {
            Carta c1 = new Carta(Seme.C, Valore.quattro);
            Carta c2 = new Carta(Seme.B, Valore.sei);
            Carta c3 = new Carta(Seme.A, Valore.otto);

            Mazzetto m = new Mazzetto();

            m.AggiungiCarta(c1);
            m.AggiungiCarta(c2);
            m.AggiungiCarta(c3);

            m.RimuoviCarta();

            Assert.AreEqual(c2, m.Carte[m.Carte.Count -1]);
        }
    }
}