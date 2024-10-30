using GameLibrary;

namespace TestGame
{
    [TestClass]
    public class UnitTestPlayRound
    {
        [TestMethod]
        public void PlayRound_RockVsScissors_WinPlayer1()
        {
            PlayerTest p1 = new PlayerTest(Symbol.rock);
            PlayerTest p2 = new PlayerTest(Symbol.scissors);
            GameManager game = new GameManager(p1, p2);

            Results expected = Results.WinP1;
            Results actual = game.Round();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlayRound_ScissorsVsPaper_WinPlayer1()
        {
            PlayerTest p1 = new PlayerTest(Symbol.scissors);
            PlayerTest p2 = new PlayerTest(Symbol.paper);
            GameManager game = new GameManager(p1, p2);

            Results expected = Results.WinP1;
            Results actual = game.Round();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlayRound_PaperVsRock_WinPlayer1()
        {
            PlayerTest p1 = new PlayerTest(Symbol.paper);
            PlayerTest p2 = new PlayerTest(Symbol.rock);
            GameManager game = new GameManager(p1, p2);

            Results expected = Results.WinP1;
            Results actual = game.Round();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlayRound_RockVsScissors_WinPlayer2()
        {
            PlayerTest p1 = new PlayerTest(Symbol.scissors);
            PlayerTest p2 = new PlayerTest(Symbol.rock);
            GameManager game = new GameManager(p1, p2);

            Results expected = Results.WinP2;
            Results actual = game.Round();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlayRound_ScissorsVsPaper_WinPlayer2()
        {
            PlayerTest p1 = new PlayerTest(Symbol.paper);
            PlayerTest p2 = new PlayerTest(Symbol.scissors);
            GameManager game = new GameManager(p1, p2);

            Results expected = Results.WinP2;
            Results actual = game.Round();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlayRound_PaperVsRock_WinPlayer2()
        {
            PlayerTest p1 = new PlayerTest(Symbol.rock);
            PlayerTest p2 = new PlayerTest(Symbol.paper);
            GameManager game = new GameManager(p1, p2);

            Results expected = Results.WinP2;
            Results actual = game.Round();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlayRound_RockVsRock_Tie()
        {
            PlayerTest p1 = new PlayerTest(Symbol.rock);
            PlayerTest p2 = new PlayerTest(Symbol.rock);
            GameManager game = new GameManager(p1, p2);

            Results expected = Results.Tie;
            Results actual = game.Round();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlayRound_ScissorsVsScissors_Tie()
        {
            PlayerTest p1 = new PlayerTest(Symbol.scissors);
            PlayerTest p2 = new PlayerTest(Symbol.scissors);
            GameManager game = new GameManager(p1, p2);

            Results expected = Results.Tie;
            Results actual = game.Round();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlayRound_PaperVsPaper_Tie()
        {
            PlayerTest p1 = new PlayerTest(Symbol.paper);
            PlayerTest p2 = new PlayerTest(Symbol.paper);
            GameManager game = new GameManager(p1, p2);

            Results expected = Results.Tie;
            Results actual = game.Round();

            Assert.AreEqual(expected, actual);
        }
    }
}