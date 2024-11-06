using MorraCineseLibrary;

namespace TestMorraCinese
{
    [TestClass]
    public class TestGameManager
    {
        [TestMethod]
        public void PlayRound_RockVsScissor_WinPlayer1()
        {
            PlayerTest rockPlayer = new PlayerTest(MorraCineseLibrary.Symbol.Rock);
            PlayerTest scissorPlayer = new PlayerTest(MorraCineseLibrary.Symbol.Scissor);

            GameManager game = new GameManager(rockPlayer, scissorPlayer);

            Result expected = Result.WinPlayer1;
            Result actual = game.PlayRound();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void PlayRound_RockVsRock_Tie()
        {
            PlayerTest rockPlayer = new PlayerTest(MorraCineseLibrary.Symbol.Rock);
            

            GameManager game = new GameManager(rockPlayer, rockPlayer);

            Result expected = Result.Tie;
            Result actual = game.PlayRound();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlayRound_ScissorVsRock_WinPlayer2()
        {
            PlayerTest rockPlayer = new PlayerTest(MorraCineseLibrary.Symbol.Rock);
            PlayerTest scissorPlayer = new PlayerTest(MorraCineseLibrary.Symbol.Scissor);

            GameManager game = new GameManager(scissorPlayer, rockPlayer);

            Result expected = Result.WinPlayer2;
            Result actual = game.PlayRound();

            Assert.AreEqual(expected, actual);

        }
    }
}