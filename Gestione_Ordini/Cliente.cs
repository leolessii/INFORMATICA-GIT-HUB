namespace Gestione_Ordini
{
    public class Cliente
    {
        private string _nome;
        private int _idCliente;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nome cliente");
                }
                _nome = value;
            }
        }

        public int IdCliente
        {
            get { return _idCliente; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id cliente");
                }
                _idCliente = value;
            }
        }

        public Cliente(string nome, int id)
        {
            _nome = nome;
            _idCliente = id;
        }
    }
}
