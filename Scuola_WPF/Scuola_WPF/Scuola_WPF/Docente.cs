using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola_WPF
{
    internal class Docente : Persona
    {
        private string _materia;
        private double _salario;

        private string Materia
        {
            get { return _materia; }
            set
            {
                if (value == null) throw new Exception("il nome della materia non può essere nullo");
                _materia = value;
            }
        }

        public double Salario
        {
            get { return _salario; }
            set
            {
                if (value <= 0) throw new Exception("il salario inserito non è accettabile");
                _salario = value;
            }
        }

        public Docente(string nome, string cognome, string codiceFiscale, string materia, double salario) : base(nome, cognome, codiceFiscale)
        {           
            Materia = materia;
            Salario = salario;
        }

        public override string ToString()
        {
            return base.ToString() + $"Materia: {_materia}, il salario è: {_salario}";
        }
    }
}
