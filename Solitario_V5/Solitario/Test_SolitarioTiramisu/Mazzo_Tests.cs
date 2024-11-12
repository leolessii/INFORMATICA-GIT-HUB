using Classi_SolitarioTiramisu;

namespace Test_SolitarioTiramisu
{
    [TestClass]
    public class Mazzo_Tests
    {
        [TestMethod]
        public void ControlloPescaCarta()
        {
            Mazzo mazzo = new Mazzo();
            mazzo.MescolaMazzo();

            Carta carta = mazzo.Carte[0];

            Assert.AreEqual(carta, mazzo.PescaCarta());
        }
    }
}