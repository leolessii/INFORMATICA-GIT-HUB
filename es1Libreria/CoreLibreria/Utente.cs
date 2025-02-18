using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibreria
{
    public class Utente
    {
        //metto get;set senza controlli solo per velocità
        public String Nome {  get; set; }
        public String Cognome {  get; set; }
        public String Id {  get; set; }

        public Utente(string nome, string cognome, string id)
        {
            Nome = nome;
            Cognome = cognome;
            Id = id;
        }

        public Utente()
        {
            
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException();
            if(!(obj is Utente ) )
                throw new ArgumentException();
            
            Utente objUtente = obj as Utente;
            return Id.Equals(objUtente.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
