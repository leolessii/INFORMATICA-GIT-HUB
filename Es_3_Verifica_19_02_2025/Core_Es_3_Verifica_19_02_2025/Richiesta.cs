using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Es_3_Verifica_19_02_2025
{
    public class Richiesta
    {
        private string _id;
        private HashSet<Campione> _campioni;

        public string Id
        {
            get { return _id; }
            set
            {
                if (string.IsNullOrEmpty(_id)) throw new ArgumentException("id");
                _id = value;
            }
        }

        public HashSet<Campione> Campioni
        {
            get { return _campioni; }
            set
            {
                if (value == null) throw new ArgumentNullException("campioni");
                _campioni = value;
            }
        }

        public Richiesta(string id, HashSet<Campione> campioni)
        {
            _id = id;
            _campioni = campioni;
        }
    }
}
