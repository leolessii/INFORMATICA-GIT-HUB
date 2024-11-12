using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_SolitarioTiramisu
{
    public class Mazzetto
    {
        private List<Carta> _carte;

        public Mazzetto()
        {
            _carte = new List<Carta>();
        }

        public List<Carta> Carte
        {
            get
            {
                return _carte;
            }
        }

        public Carta CartaInCima 
        {
            get
            {  
                if(_carte.Count > 0 )
                return _carte.Last(); 
            else 
               return null;
            }
        }

        public void RigeneraMazzetto()
        {
            List<Carta> c = new List<Carta>();
            _carte = c;
        }

        public void AggiungiCarta(Carta carta)
        {
          
                _carte.Add(carta);
            
        }

        public void RimuoviCarta()
        {
            if(_carte.Count > 0 )
            {
                _carte.RemoveAt(_carte.Count - 1);
            }
        }
    }
}
