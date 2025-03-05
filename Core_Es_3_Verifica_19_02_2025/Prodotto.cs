namespace Core_Es_3_Verifica_19_02_2025
{
    public class Prodotto
    {
        private string _nome;
        private string _marca;
        private string _sKU;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("nome prodotto");
                _nome = value;
            }
        }

        public string Marca
        {
            get { return _marca; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("marca prodotto");
                _marca = value;
            }
        }

        public string SKU
        {
            get { return _sKU; }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentException("SKU prodotto");
                _sKU = value;
            }
        }

        public Prodotto(string nome, string marca, string sKU)
        {
            _nome = nome;
            _marca = marca;
            _sKU = sKU;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) throw new ArgumentNullException("equals prodotto");
            if (!(obj is Prodotto)) throw new ArgumentException("obj non è prodotto");

            Prodotto objProdotto = (obj as Prodotto)!;
            return SKU.Equals(objProdotto.SKU);
        }

        public override string ToString()
        {
            return $"{Nome} - {Marca} - {SKU}";
        }
    }
}
