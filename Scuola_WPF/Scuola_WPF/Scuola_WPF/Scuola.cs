using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola_WPF
{
    internal class Scuola
    {
        private List<Classe> _classi;
        private List<CollaboratoreEsterno> _collaboratori;

        public List<Classe> Classi
        {
            get { return _classi; }
        }

        public List<CollaboratoreEsterno> Collaboratori
        {
            get { return _collaboratori; }
        }

        public Scuola()
        {
             _classi = new List<Classe>();
             _collaboratori = new List<CollaboratoreEsterno>();
        }

        public void AggiugniClasse(Classe c)
        {
            _classi.Add(c);
        }

        public void AggiungiCollaboratore(CollaboratoreEsterno collaboratore)
        {
            _collaboratori.Add(collaboratore);
        }


    }
}
