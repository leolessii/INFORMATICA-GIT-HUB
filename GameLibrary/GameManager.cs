namespace GameLibrary
{
    public enum Symbol
    {
        rock, 
        paper, 
        scissors
    }

    public enum Results
    {
        WinP1,
        WinP2,
        Tie
    }

    public class GameManager
    {
        private IPlayer _player1;
        private IPlayer _player2;
        private IOutput _output;

        public GameManager(IPlayer player1, IPlayer player2, IOutput? output=null)
        {
            _player1 = player1;
            _player2 = player2;
            _output = output;
        }

        public Results Round()
        {
            Symbol p1Choice = _player1.GetChoice();
            Symbol p2Choice = _player2.GetChoice();

            if(_output != null)
            {
                _output.OutputChoice(p1Choice, p2Choice);
            }

            if(p1Choice == p2Choice)
            {
                return Results.Tie;
            }

            if (p1Choice == Symbol.rock && p2Choice == Symbol.scissors || p1Choice == Symbol.scissors && p2Choice == Symbol.paper || p1Choice == Symbol.paper && p2Choice == Symbol.rock)
            {
                return Results.WinP1;
            }
            else return Results.WinP2;
        }
    }
}
