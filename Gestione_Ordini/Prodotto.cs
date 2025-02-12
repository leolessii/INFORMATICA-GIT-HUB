using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Ordini
{
    public class Prodotto
    {
        private string _nome;
        private double _prezzo;
        private int _idProdotto;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nome cliente");
                }
                _nome = value;
            }
        }

        public double Prezzo
        {
            get { return _prezzo; }
            set
            {
                if(value < 0.0)
                {
                    throw new ArgumentException("prezzo prodotto");
                }
                _prezzo = value;
            }
        }

        public int IdProdotto
        {
            get { return _idProdotto; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id prodotto");
                }
                _idProdotto = value;
            }
        }

        public Prodotto(string nome, double prezzo, int idProdotto)
        {
            _nome = nome;
            _prezzo = prezzo;
            _idProdotto = idProdotto;
        }
    }
}
