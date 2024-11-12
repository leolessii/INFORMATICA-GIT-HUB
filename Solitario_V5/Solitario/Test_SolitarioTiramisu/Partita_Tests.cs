using Classi_SolitarioTiramisu;

namespace Test_SolitarioTiramisu
{
    [TestClass]
    public class Partita_Tests
    {
        [TestMethod]
        public void SpostaCartaManoSbagliato()
        {
            Partita p = new Partita("GIACOMO");
            Carta c = new Carta(Seme.A, Valore.asso);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { p.SpostaCarta(true, c, 6); });
        }

        [TestMethod]
        public void SpostaCartaDaManoATavoloSbagliato()
        {
            Partita p = new Partita("GIACOMO");
            Carta c = new Carta(Seme.A, Valore.asso);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { p.SpostaCarta(false ,c, 6); });
        }

        [TestMethod]
        public void PescaCarta()
        {
            Partita p = new Partita("GIACOMO");       
        }

        [TestMethod]
        public void RimuoviCarta()
        {
            Mazzetto m = new Mazzetto();
            Carta c = new Carta(Seme.A, Valore.tre);
            Carta c1 = new Carta(Seme.A, Valore.quattro);
            Carta c2 = new Carta(Seme.A, Valore.cinque);

            Mazzetto m1 = new Mazzetto();
            m1.AggiungiCarta(c);
            m1.AggiungiCarta(c2);

            m.AggiungiCarta(c);
            m.AggiungiCarta(c2);
            m.AggiungiCarta(c1);

            m.RimuoviCarta();

            Assert.AreEqual(m.Carte.Count, 2);
           
        }
    }
}