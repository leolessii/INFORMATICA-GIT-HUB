namespace CoreLibreria
{
    public class Libro
    {
        private String _titolo;
        public String Titolo
        {
            get { return _titolo; }
            private set {
                if (value != String.Empty)
                {
                    _titolo = value;
                }
                else { throw new ArgumentNullException(); }
            }
        }
        private String _autore;
        public String Autore
        {
            get { return _autore; }
            private set
            {
                if (value != String.Empty)
                {
                    _autore = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        private String _isbn;        
        public String ISBN
        {
            get { return _isbn; }
            private set
            {
                if (value != String.Empty)//dovrei controllare anche le 13 cifre
                {
                    _isbn = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        private String _numeroInventario;
        public String NumeroInventario
        {
            get { return _numeroInventario; }
            private set
            {
                if (value != String.Empty)//dovrei controllare anche le 13 cifre
                {
                    _numeroInventario = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        private int _annoPubblicazione;
        public int AnnoPubblicazione
        {
            get { return _annoPubblicazione; }
            private set
            {
                if (value >0)
                {
                    _annoPubblicazione = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public Libro(string titolo, string autore, string isbn, int annoPubblicazione, string numeroInventario)
        {
            Titolo = titolo;
            Autore = autore;
            ISBN = isbn;
            AnnoPubblicazione = annoPubblicazione;
            NumeroInventario = numeroInventario;
        }

        public Libro()
        {
            
        }

        public override int GetHashCode()
        {
            return NumeroInventario.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException();
            if (!(obj is Libro))
                throw new ArgumentException();

            Libro objLibro = obj as Libro;
            return NumeroInventario.Equals(objLibro.NumeroInventario);
        }

        public override string ToString()
        {
            return $"{NumeroInventario} - {Titolo} - {Autore} - {ISBN}";
        }
    }
}
