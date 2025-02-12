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
        private Stack<Libro> _prestitiAttivi;
        private Queue<Prestito> _prestitiInAttesa;

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
        }
        public HashSet<Utente> Utenti
        {
            get { return _utenti; }
        }
        public Stack<Libro> PrestitiAttivi
        {
            get { return _prestitiAttivi; }
        }
        public Queue<Prestito> PrestitiInAttesa
        {
            get { return _prestitiInAttesa; }
        }

        public Libreria(string nome) 
        {
            Nome = nome;
            _libri = new HashSet<Libro>();
            _utenti = new HashSet<Utente>();
            _prestitiAttivi = new Stack<Libro>();
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
                if (_prestitiAttivi.Contains(libro))
                {
                    //altrimenti lo aggiungo alla coda dei prestiti
                    _prestitiInAttesa.Enqueue(prestito);
                    return false;
                }
                else
                {
                    _prestitiAttivi.Push(libro);
                    return true;
                }
            }
            else
            {
                throw new Exception($"il libro {libro} non è a disposizione della libreria");
            }
        }

        /*
        public bool RimuoviPrestito(Libro libro)
        {
            if (_prestitiAttivi.Contains(libro))
            {
                _prestitiAttivi.Pop();
            }
            else
            {
                throw new Exception($"il libro {libro} non è a disposizione della libreria");
            }
        }
        */

        public bool CercaPrestitiAttivi(Libro libro)
        {
            return _prestitiAttivi.Contains(libro);
        }

        public bool CercaPrestitiInAttesa(Prestito prestito)
        {
            return _prestitiInAttesa.Contains(prestito);
        }
    }
}
