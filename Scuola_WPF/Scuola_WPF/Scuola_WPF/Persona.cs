using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola_WPF
{
    internal abstract class Persona
    {
        private string _nome;
        private string _cognome;
        private string _codiceFiscale;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value == null)
                {
                    throw new Exception("il nome inserito non è accettabile");
                }
                _nome = value;
            }
        }

        public string Cognome
        {
            get { return _cognome; }
            set
            {
                if (value == null)
                {
                    throw new Exception("il cognome inserito non è accettabile");
                }
                _cognome = value;
            }
        }

        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set
            {
                if (value.Length != 16)
                {
                    throw new Exception("il codice fiscale non è accettabile");
                }
                _codiceFiscale = value;
            }
        }

        public Persona(string nome, string cognome, string codiceFiscale)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
        }

        

        public override string ToString()
        {
            return $"Nome: {_nome}, Cognome: {_cognome}, Codice Fiscale: {_codiceFiscale}";
        }
    }
}

