using Classi_SolitarioTiramisu;
namespace Test_SolitarioTiramisu
{
    [TestClass]
    public class Giocatore_Tests
    {
        [TestMethod]
        public void ControlloNomeGiocatore()
        {
            Assert.ThrowsException<ArgumentNullException>(() => { Giocatore g = new Giocatore(""); }) ;
        }
    }
}