using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibreria
{
    public class Libreria
    {
        private string _nome;
        private HashSet<Libro> _libri;
        private HashSet<Utente> _utenti;
        private Dictionary<Libro, Prestito> _prestitiAttivi;
        private Queue<Prestito> _prestitiInAttesa;
        private XML _serializzatore;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("nome libreria");
                }
                _nome = value;
            }
        }

        public HashSet<Libro> Libri
        {
            get { return _libri; }
            set { }
        }
        public HashSet<Utente> Utenti
        {
            get { return _utenti; }
            set { }
        }
        public Dictionary<Libro, Prestito> PrestitiAttivi
        {
            get { return _prestitiAttivi; }
            set {}
        }
        public Queue<Prestito> PrestitiInAttesa
        {
            get { return _prestitiInAttesa; }
            set { }
        }

        public Libreria(string nome) 
        {
            _nome = nome;
            _libri = new HashSet<Libro>();
            _utenti = new HashSet<Utente>();
            _prestitiAttivi = new Dictionary<Libro, Prestito>();
            _prestitiInAttesa = new Queue<Prestito>();
            _serializzatore = new XML();
            //load dei dati da file
        }

        public Libreria()
        {
            Nome = "nome";
            _libri = new HashSet<Libro>();
            _utenti = new HashSet<Utente>();
            _prestitiAttivi = new Dictionary<Libro, Prestito>();
            _prestitiInAttesa = new Queue<Prestito>();
            //load dei dati da file
        }

        //_libri
        public bool Aggiungilibro(Libro libro)
        {
            return _libri.Add(libro);
        }

        public bool RimuoviLibro(Libro libro)
        {
            return _libri.Remove(libro);
        }

        public bool CercaLibro(Libro libro)
        {
            return _libri.Contains(libro);
        }

        //_utenti
        public bool AggiungiUtente(Utente utente)
        {
            return _utenti.Add(utente);
        }

        public bool RimuoviUtenti(Utente utente)
        {
            return _utenti.Remove(utente);
        }

        public bool CercaUtente(Utente utente)
        {
            return _utenti.Contains(utente);
        }

        //Prestiti
        public bool AggiungiPrestito(Libro libro, Utente utente)
        {
            //verifico che sia nella lista dei libri in nostro possesso
            if (_libri.Contains(libro)&&_utenti.Contains(utente))
            {
                Prestito prestito = new Prestito(libro, utente, DateTime.Now, DateTime.Now.AddMonths(1));

                //verifico che il libro non sia già in prestito ovvero che nel dizionario non si apresente la chiave libro
                if (_prestitiAttivi.ContainsKey(libro))
                {
                    //altrimenti lo aggiungo alla coda dei prestiti
                    _prestitiInAttesa.Enqueue(prestito);
                    return false;
                }
                else
                {
                    _prestitiAttivi.Add(libro, prestito);
                    return true;
                }
            }
            else
            {
                throw new Exception($"il libro {libro} non è a disposizione della libreria");
            }
        }
        
        public bool RimuoviPrestito(Libro libro, Prestito prestito)
        {
            if (_prestitiAttivi.ContainsKey(libro) && _prestitiAttivi.ContainsValue(prestito))
            {
                return _prestitiAttivi.Remove(libro, out prestito);
            }
            else
            {
                throw new Exception($"il libro {libro} non è a disposizione della libreria");
            }
        }

        public bool CercaPrestitiAttivi(Libro libro)
        {
            return _prestitiAttivi.ContainsKey(libro);
        }

        public bool CercaPrestitiInAttesa(Prestito prestito)
        {
            return _prestitiInAttesa.Contains(prestito);
        }
    }
}
