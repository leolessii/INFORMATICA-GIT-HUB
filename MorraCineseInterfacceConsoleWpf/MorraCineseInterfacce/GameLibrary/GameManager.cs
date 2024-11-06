using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorraCineseLibrary
{
    public enum Symbol
    {
        Rock,
        Paper,
        Scissor
    }

    public enum Result
    {
        WinPlayer1,
        WinPlayer2,
        Tie
    }
    public class GameManager
    {

        //al gamemanager non importa se il giocatore è Human, Test o Pc, a lui importa che possa fare una scelta ovvero che implementi l'interfaccia IPlayer
        private IPlayer _player1;
        private IPlayer _player2;
        
        private IOutputInterface _outputInterface;

        /// <summary>
        /// imposto i giocatori e l'interfaccia di output che può anche non essere presente
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        public GameManager(IPlayer player1, IPlayer player2, IOutputInterface? output=null)
        {
            _player1 = player1;
            _player2 = player2;
            _outputInterface = output;
        }

        public Result PlayRound()
        {
            //ad ogni round prendo la scelta dei player (qui non mi importa se arriva dalla console, se è random o predefinita come per i test,
            //a me importa che sia possibile avere la scelta del giocatore non come questa arriva!)
            Symbol player1Choice = _player1.GetChoice();
            Symbol player2Choice = _player2.GetChoice();

            //voglio visualizzare le giocate prima di dire chi ha vinto, qui non posso sapere (e non mi importa saperlo perchè il mio comportamento non deve essere influenzato dal tipo di output)
            //dove dovrò inviare l'output (console, wpf, file, ...) quindi utilizzo una interfaccia
            if (_outputInterface != null)
            {
                _outputInterface.OutputChoices(player1Choice, player2Choice);
            }

            //logica di controllo del vicnitore del round e restituzione del risultato
            if(player1Choice == player2Choice) {return Result.Tie;}
            if (player1Choice == Symbol.Rock && player2Choice == Symbol.Scissor
                || player1Choice == Symbol.Scissor && player2Choice == Symbol.Paper
                || player1Choice == Symbol.Paper && player2Choice == Symbol.Rock)
            {
                return Result.WinPlayer1;
            }
            return Result.WinPlayer2;
        }

    }
}
