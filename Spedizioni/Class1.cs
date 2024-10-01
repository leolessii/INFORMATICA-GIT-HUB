namespace Spedizioni
{
    public class Pack
    {
        public string _id;
        public string _destination;
        public DateOnly _speditionDate;
        public DateOnly _deliveryDate;
        public double _weight;
        public string _city;

        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Destination
        {
            get { return _destination; }
            private set { _destination = value; }
        }

        public DateOnly SpeditionDate
        {
            get { return _speditionDate; }
            private set { _speditionDate = value; }
        }

        public DateOnly DeliveryDate
        {
            get { return _deliveryDate; }
            private set { _deliveryDate = value; }
        }

        public double Weight
        {
            get { return _weight; }
            private set { _weight = value; }
        }

        public string City
        {
            get { return _city; }
            private set { _city = value; }
        }

        public Pack(string id, string destination, DateOnly speditionDate, DateOnly deliveryDate, double weight, string city)
        {
            _id = id;
            _destination = destination;
            _speditionDate = speditionDate;
            _deliveryDate = deliveryDate;
            _weight = weight;
            _city = city;
        }

        public bool Equals(string id)
        {
            if(id == null) return false;
            if(id == Id) return true;
            else return false;
        }

    }
}