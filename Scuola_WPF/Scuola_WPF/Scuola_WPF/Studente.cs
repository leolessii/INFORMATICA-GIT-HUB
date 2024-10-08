using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola_WPF
{
    internal class Studente : Persona
    {
        private int _matricola;
        private int _classe;
        private char _sezione;

        public int Matricola
        {
            get { return _matricola; }
            set
            {
                if (value == null) throw new Exception("il numero di matricola non può essere nullo");
                _matricola = value;
            }
        }

        public int Classe
        {
            get { return _classe; }
            set
            {
                if (value <= 0 || value > 5) throw new Exception("la classe inserita non è accettabile");
                _classe = value;
            }
        }

        public char Sezione
        {
            get { return _sezione; }
            set
            {
                if (value == null) throw new Exception("la sezione inseirita non è accettabile");
                _sezione = value;
            }
        }

        public Studente(string nome, string cognome, string codiceFiscale, int matricola):base(nome,cognome, codiceFiscale)
        {
            Matricola = matricola;
            //valorid i default che assegno a Sezioen e Classe quando lo studente non ha ancora una classe associata
            Sezione = '0';
            Classe = 0;
        }

        public Studente(string nome, string cognome, string codiceFiscale, int matricola, int classe, char sezione) : base(nome, cognome, codiceFiscale)
        {           
            Matricola = matricola;
            Classe = classe;
            Sezione = sezione;
        }

        public override string ToString()
        {
            return base.ToString() + $"Numero di Matricola: {_matricola}, la classe è: {_classe}, la sezione è: {_sezione}";
        }
    }
}