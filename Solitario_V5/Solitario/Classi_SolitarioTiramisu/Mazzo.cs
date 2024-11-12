 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_SolitarioTiramisu
{
    public class Mazzo
    {
        private Carta?[] _carte;
        private bool _mazzoTerminato;

        public Mazzo()
        {
            _carte = new Carta[40];

            InizializzaMazzo();
            MescolaMazzo();
            _mazzoTerminato = false;
        }
        public Carta[] Carte
        {
            get { return _carte; }

            private set
            {
                if (value.Length < 0) throw new ArgumentException("dimensione del mazzo errata");

                _carte = value;
            }
        }

        public bool MazzoTerminato
        {
            get { return _mazzoTerminato; }
        }

        public Carta PescaCarta()
        {
            Carta carta=null;
            int cont = 0;
            for (int i = 0; i < _carte.Length; i++)
            {
                if (_carte[i] != null)
                {
                    carta = _carte[i];
                    if (carta.ValoreCarta == 0) throw new ArgumentException("pesca carta");
                    _carte[i] = null;
                    break;
                }
                cont++;
            }
            if(cont==40 || cont == 39)
            {
                _mazzoTerminato = true;
            }

            return carta;
        }


        private void InizializzaMazzo()
        {
            int pos = 0;

            for (int seme = 0; seme <= 3; seme++)
            {
                for (int valore = 1; valore <= 10; valore++)
                {
                    _carte[pos] = new Carta((Seme)seme, (Valore)valore);
                    if (_carte[pos].ValoreCarta == 0) throw new ArgumentException(_carte[pos].ValoreCarta.ToString());
                    pos++
                        ;
                }
            }
        }

        public void MescolaMazzo()
        {
            Random random = new Random();
            int pos;
            Carta cartaDaScambiare;
            for (int j = 0; j < 1000; j++)
            {
                for (int i = 0; i < _carte.Length; i++)
                {
                    pos = random.Next(0, _carte.Length);
                    cartaDaScambiare = _carte[pos];
                    _carte[pos] = _carte[i];
                    _carte[i] = cartaDaScambiare;
                }
            }
        }

        public void RigeneraMazzo(Mazzetto[] mano)
        {
            int x = -1;
            int y;
            Mazzetto m = new Mazzetto();
            y = mano[0].Carte.Count;
            if (!mano[0].Carte.Contains(null))
            {
                y++;
            }
            for (int i = 0; i < y-1 ; i++)
            {
                x++;
                _carte[x] = mano[0].Carte[i];
            }
            y = mano[1].Carte.Count;
            if (!mano[1].Carte.Contains(null))
            {
                y++;
            }

            for (int i = 0; i < y-1; i++)
            {
                x++;
                _carte[x] = mano[1].Carte[i];

            }
            y = mano[2].Carte.Count;
            if (!mano[2].Carte.Contains(null))
            {
                y++;
            }

            for (int i = 0; i < y-1; i++)
            {
                x++;
                _carte[x] = mano[2].Carte[i];


            }
            y = mano[3].Carte.Count;
            if (!mano[3].Carte.Contains(null))
            {
                y++;
            }

            for (int i = 0; i < y-1; i++)
            {
                x++;
                _carte[x] = mano[3].Carte[i];


            }
            _mazzoTerminato = false;

            mano[0].RigeneraMazzetto();
            mano[1].RigeneraMazzetto();
            mano[2].RigeneraMazzetto();
            mano[3].RigeneraMazzetto();
            
        }

    } 
}

