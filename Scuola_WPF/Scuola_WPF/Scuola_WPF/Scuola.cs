using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola_WPF
{
    internal class Scuola
    {
        
        private List<Studente> _studenti;
        private List<Docente> _docenti;
        private List<CollaboratoreEsterno> _collaboratori;

        public List<Studente> Studenti
        {
            get { return _studenti; }
        }

        public List<Docente> Docenti
        {
            get { return _docenti; }
        }

        public List<CollaboratoreEsterno> Collaboratori
        {
            get { return _collaboratori; }
        }

        public Scuola()
        {
             _studenti = new List<Studente>();
             _docenti = new List<Docente>();
             _collaboratori = new List<CollaboratoreEsterno>();
        }

        public void AggiungiStudente(Studente studente)
        {
            _studenti.Add(studente);
        }

        public void AggiungiDocente(Docente docente)
        {
            _docenti.Add(docente);
        }

        public void AggiungiCollaboratore(CollaboratoreEsterno collaboratore)
        {
            _collaboratori.Add(collaboratore);
        }


    }
}
