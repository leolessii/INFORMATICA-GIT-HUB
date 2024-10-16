using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola_WPF
{
    internal class Studente : Persona
    {
        private int? _matricola;

        public int? Matricola
        {
            get { return _matricola; }
            set
            {
                if (value == null) throw new Exception("il numero di matricola non può essere nullo");
                _matricola = value;
            }
        }

        public Studente(string nome, string cognome, string codiceFiscale, int matricola):base(nome,cognome, codiceFiscale)
        {
            Matricola = matricola;
        }

        public override string ToString()
        {
            return base.ToString() + $"Numero di Matricola: {_matricola}";
        }
    }
}