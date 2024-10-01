namespace Spedizioni
{
    public class Pack
    {
        protected int _id;
        protected string _destination;
        protected double _paymentAtDelivery;
        protected DateOnly _speditionDate;
        protected DateOnly _deliveryDate;
        protected double _weight;

        protected int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        protected string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        protected double PaymentAtDelivery
        {
            get { return _paymentAtDelivery; }
            set { _paymentAtDelivery = value; }
        }

        protected DateOnly SpeditionDate
        {
            get { return _speditionDate; }
            set { _speditionDate = value; }
        }

        protected DateOnly DeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        protected double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Pack(string destination, double paymentAtDelivery, DateOnly speditionDate, DateOnly deliveryDate, double weight)
        {
            Random rnd = new Random();
            _id = rnd.Next(+1);
            _destination = destination;
            _paymentAtDelivery = paymentAtDelivery;
            _speditionDate = speditionDate;
            _deliveryDate = deliveryDate;
            _weight = weight;
        }

        public Pack(string destination, DateOnly speditionDate, DateOnly deliveryDate, double weight) 
        {
            Random rnd = new Random();
            _id = rnd.Next(+1);
            _destination = destination;
            _speditionDate = speditionDate;
            _deliveryDate = deliveryDate;
            _weight = weight;
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) return false;
            obj = obj as Pack;
            // non trova l'id in obj
            if(obj.Id == Id) return true;
            else return false;
        }

    }
}