using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_SolitarioTiramisu
{
    public enum Seme
    {
        A,
        B,
        C,
        D
    }

    public enum Valore
    {
        asso = 1,
        due,
        tre,
        quattro,
        cinque,
        sei,
        sette,
        otto,
        nove,
        dieci
    }
    public class Carta : IEquatable<Carta>
    {
        private Seme _semeCarta;
        private Valore _valoreCarta;
        private string _fronte = AppContext.BaseDirectory + "carte\\";
        private string _retro = AppContext.BaseDirectory + "carte\\RETRO.jpg";

        public Seme SemeCarta
        {
            get { return _semeCarta; }

            private set
            {
                if (Convert.ToInt16(value) > 3 || Convert.ToInt16(value) < 0) throw new ArgumentException("seme");
                _semeCarta = value;
            }
        }

        public Valore ValoreCarta
        {
            get { return _valoreCarta; }

            private set
            {
                if (Convert.ToInt16(value) > 10 || Convert.ToInt16(value) < 1) throw new ArgumentException("valore");

                _valoreCarta = value;
            }
        }

        public string Fronte
        {
            get
            {
                return _fronte;
            }

        }

        public string Retro
        {
            get
            {
                return _retro;
            }
        }



        public Carta(Seme seme, Valore valore)
        {
            ValoreCarta = valore;
            SemeCarta = seme;
            _fronte += Convert.ToInt16(_valoreCarta).ToString() + SemeCarta.ToString() + ".jpg";
        }

        public bool Equals(Carta? obj)
        {
            if (this.ToString() == obj.ToString()) return true;

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(SemeCarta.ToString());

            return sb.ToString();
        }
    }
}