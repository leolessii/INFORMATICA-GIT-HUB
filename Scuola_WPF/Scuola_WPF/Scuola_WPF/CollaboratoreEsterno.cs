using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scuola_WPF
{
    internal class CollaboratoreEsterno : Persona
    {
        public string mail;

        public string Mail
        {
            get {  return mail; }
            set
            {
                if(value == null)   throw new ArgumentNullException("value");
                mail = value; 
            }
        }

        public CollaboratoreEsterno(string nome, string cognome, string codiceFiscale, string mail) : base (nome, cognome, codiceFiscale)
        {
            Mail = mail;
        }
    }
}
