using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Es_3_Verifica_19_02_2025
{
    public class Campione
    {
        private Prodotto _prodotto;
        private string _numeroInventario;
        private bool _disponibile;
        
        public Prodotto Prodotto
        {
            get { return _prodotto; }
            set
            {
                if (value == null) throw new ArgumentNullException("prodotto nullo");
                _prodotto = value;
            }
        }

        public string NumeroInventario
        {
            get { return _numeroInventario; }
            set
            {
                if(string.IsNullOrEmpty(value)) throw new ArgumentException("numero inventario");
                _numeroInventario = value;
            }
        }

        public bool Disponibile
        {
            get { return _disponibile; }
            set { _disponibile = value; }
        }

        public Campione (Prodotto prodotto, string numeroInventario, bool disponibile)
        {
            _prodotto = prodotto;
            _numeroInventario= numeroInventario;
            _disponibile= disponibile;
        }

        public override int GetHashCode()
        {
            return $"{_prodotto.SKU}{NumeroInventario}".GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException();
            if (!(obj is Campione))
                throw new ArgumentException();
            Campione objCopia = (obj as Campione)!;
            return _numeroInventario.Equals(objCopia.NumeroInventario);
        }
        public override string ToString()
        {
            return $"{_numeroInventario} - {_prodotto}";
        }

    }
}
