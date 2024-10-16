using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Scuola_WPF
{
    internal class Classe
    {
        private List<Studente> _studenti;
        private List<Docente> _docenti;
        private int? _anno;
        private char? _sezione;

        public List<Studente> Studenti
        {
            get { return _studenti; }
            set { _studenti = value; }
        }

        public List<Docente> Docenti
        {
            get { return _docenti; }
            set { _docenti = value; }
        }

        public int? Anno
        {
            get { return _anno; }
            set 
            {
                if(value <= 0 || value > 5) throw new ArgumentOutOfRangeException("classe");
                _anno = value; 
            }
        }

        public char? Sezione
        {
            get { return _sezione;}
            set
            {
                if(value == null) throw new ArgumentNullException("sezione");
            }
        }

        public Classe(int anno, char sezione)
        {
            _studenti = new List<Studente>();
            _docenti = new List<Docente>();
            _anno = anno;
            _sezione = sezione;
        }

        public void AggiungiStudente(Studente s)
        {
            bool presente = false;
            if(s!= null)
            {
                for(int i =0;  i < _studenti.Count; i++)
                {
                    if (Studenti[i] == s)
                    {
                        presente = true;
                    }
                }
                if (presente == false)
                {
                    Studenti.Add(s);
                }
            }
        }

        public void TogliStudente(Studente s)
        {
            if (s != null)
            {
                for (int i = 0; i < Studenti.Count; i++)
                {
                    if(Studenti[i] == s)
                    {
                        Studenti.Remove(s);
                    }
                }
            }
        }

        public void AggiungiDocente(Docente d)
        {
            bool presente = false;
            if (d != null)
            {
                for (int i = 0; i < _docenti.Count; i++)
                {
                    if (Docenti[i] == d)
                    {
                        presente = true;
                    }
                }
                if (presente == false)
                {
                    Docenti.Add(d);
                }
            }
        }

        public void TogliDocente(Docente d)
        {
            if (d != null)
            {
                for (int i = 0; i < _docenti.Count; i++)
                {
                    if (Docenti[i] == d)
                    {
                        Docenti.Remove(d);
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"{Anno}" + $"{Sezione}";
        }
    }
}
