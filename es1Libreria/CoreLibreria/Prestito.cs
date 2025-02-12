using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibreria
{
    public class Prestito
    {
        //metto get;set senza controlli solo per velocità
        public Libro Libro { get; set; }
        public Utente Utente { get; set; }
        public DateTime DataInizioPrestito { get; set; }
        //il set dovrebbe essere controllato (non dvee essere prima della data di inizio etc..)
        public DateTime DataRestituzionePrevista { get; set; }

        //sarebbe opportuno la data di restituzione prevista controllarla
        public Prestito(Libro libro, Utente utente, DateTime dataInizioPrestito, DateTime dataRestituzionePrevista)
        {
            Libro = libro;
            Utente = utente;
            DataInizioPrestito = dataInizioPrestito;
            DataRestituzionePrevista = dataRestituzionePrevista;
        }
    }
}
