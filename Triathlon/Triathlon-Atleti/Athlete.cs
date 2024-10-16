namespace Triathlon_Atleti
{
    public abstract class Athlete
    {
        protected string _name;
        protected string _surname;
        protected string _id;

        protected string Name
        {
            get { return _name; }
            set
            {
                if (value.Length > 40) throw new ArgumentException("the name is not valid");
                _name = value;
            }
        }

        protected string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length > 40) throw new ArgumentException("the last name is not valid");
                _surname = value;
            }
        }

        protected string Id
        {
            get { return _id; }
            set
            {
                if (value.Length > 4) throw new ArgumentException("the id is not valid");
                _id = value;
            }
        }

        public Athlete (string name, string lastName,  string id)
        {
            _name = name;
            _surname = lastName;
            _id = id;
        }

        public virtual int? FinalResults()
        {
            return null;
        }
    }
}
