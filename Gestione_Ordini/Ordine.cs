using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Ordini
{
    public class Ordine
    {
        private int _idOrdine;
        public Cliente _cliente;
        public DateOnly _dataOrdine;
        private Dictionary<Prodotto, int> _elencoProdotti;

        public int IdOrdine
        {
            get { return _idOrdine; }
            set 
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Id ordine");
                _idOrdine = value; 
            }
        }

        public Ordine(int idOrdine, Cliente cliente, DateOnly dataOrdine, Dictionary<Prodotto, int> elencoProdotti)
        {
            _idOrdine = idOrdine;
            _cliente = cliente;
            _dataOrdine = dataOrdine;
            _elencoProdotti = elencoProdotti;
        }
    }
}
