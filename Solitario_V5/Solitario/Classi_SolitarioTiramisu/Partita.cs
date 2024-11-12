using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_SolitarioTiramisu
{
    public class Partita
    {
        private Mazzo _mazzo;

        private Mazzetto[] _tavolo;
        private Mazzetto[] _mano;
        private Giocatore _giocatore;

        public Partita(string nome)
        {
            _mazzo = new Mazzo();

            _tavolo = new Mazzetto[4];
            _tavolo[0] = new Mazzetto();
            _tavolo[1] = new Mazzetto();
            _tavolo[2] = new Mazzetto();
            _tavolo[3] = new Mazzetto();

            _mano = new Mazzetto[4];
            _mano[0] = new Mazzetto();
            _mano[1] = new Mazzetto();
            _mano[2] = new Mazzetto();
            _mano[3] = new Mazzetto();

            _giocatore = new Giocatore(nome);
        }

        public Giocatore Giocatore
        {
            get { return _giocatore; }
        }

        public Mazzetto[] Mano
        {
            get { return _mano; }
        }

        public Mazzetto[] Tavolo
        {
            get
            {
                return _tavolo;
            }
        }

        public Mazzo Mazzo
        {
            get { return _mazzo; }
        }

        public void PescaDalMazzo()
        {
            if (!_mazzo.MazzoTerminato)
            {
                Carta carta=_mazzo.PescaCarta();
                if(carta != null)
                {
                    _mano[0].AggiungiCarta(carta);
                }
                carta = _mazzo.PescaCarta();
                if (carta != null)
                {
                    _mano[1].AggiungiCarta(carta);
                }
                carta = _mazzo.PescaCarta();
                if (carta != null)
                {
                    _mano[2].AggiungiCarta(carta);
                }
                carta = _mazzo.PescaCarta();
                if (carta != null)
                {
                    _mano[3].AggiungiCarta(carta);
                }
            }
            else
            {
                _mazzo.RigeneraMazzo(_mano);
            }

        }
         
    
        public void SpostaCartaMano(Carta carta, int mazzettoDestinazione)
        {
            if (mazzettoDestinazione < 0 || mazzettoDestinazione > 3)
                throw new Exception();

            _mano[mazzettoDestinazione].AggiungiCarta(carta);

        }


        public bool SpostaCarta(bool destinazione, Carta c, int mazzettoDestinazione)  // destinazione --> true == mano
        {
            if (c is not Carta) return false;

            if (mazzettoDestinazione < 0 || mazzettoDestinazione > 3) throw new ArgumentOutOfRangeException();

            if (destinazione)
            {
                if (SuccessioneCartaManoMano(c, _mano[mazzettoDestinazione].CartaInCima))
                {
                    _mano[mazzettoDestinazione].AggiungiCarta(c);
                    return true;
                }
            }
            else
            {
                if (SuccessioneCartaManoTavolo(c, _tavolo[mazzettoDestinazione].CartaInCima))
                {
                    _tavolo[mazzettoDestinazione].AggiungiCarta(c);
                    return true;
                }

            }

            return false;
        }

        public bool TerminaPartita()
        {
           
            for (int i = 0; i < _tavolo.Length; i++)
            {
                if (_tavolo[i].Carte.Count != 10)
                    return false;
            }

            return true;
        }

        private bool SuccessioneCartaManoTavolo(Carta carta1, Carta carta2)
        {
            if (carta2 == null && (int)carta1.ValoreCarta == 1)
            {
                return true;
            }
            else if (carta2 == null)
            {
                return false;
            }
            else if (carta1.ValoreCarta - 1 == carta2.ValoreCarta && carta1.SemeCarta == carta2.SemeCarta)
            {
                return true;
            }

            return false;

        }

        private bool SuccessioneCartaManoMano(Carta carta1, Carta carta2)
        {
            if (carta2 == null)
            {
                return true;
            }
            else if (carta1.SemeCarta == carta2.SemeCarta)
            {
                return true;
            }
            
            return false;

        }
    }
}
