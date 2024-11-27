namespace WonderLift
{
    public enum Type
    {
        Base,
        Healthy
    }
    public enum Mode
    {
        Up, 
        Down,
        Rest
    }
    public abstract class Lift
    {
        protected Type _typeOfLift;
        protected Mode _modeOfLift;
        protected List<Floor> _floors;
        protected int _actualFloor;
        protected int _maximumFloor;
        protected int _minimumFloor;
        protected string _name;
        protected int _numberOfFloors;
        protected int _speed;
        protected PeriodicTimer _t;
        protected TimeSpan _ts;

        protected Type TypeOfLift
        {
            get { return _typeOfLift; }
            set
            {
                if (value < Type.Base || value > Type.Healthy) throw new ArgumentOutOfRangeException("type of lift");
                _typeOfLift = value;
            }
        }

        protected Mode ModeOfLift
        {
            get { return _modeOfLift; }
            set
            {
                if (value < Mode.Up || value > Mode.Down) throw new ArgumentOutOfRangeException("mode of lift");
                _modeOfLift = value;
            }
        }

        protected List<Floor> Floors
        {
            get { return _floors; }
        }

        protected int ActualFloor
        {
            get { return _actualFloor; }
            set 
            {
                if(value < 0 || value == null) throw new ArgumentException("initial floor");
                _actualFloor = value; 
            }
        }

        protected int MaximumFloor
        {
            get { return _maximumFloor; }
            set
            {
                if (value < 0 || value == null) throw new ArgumentException("maximum floor");
                _maximumFloor = value;
            }
        }

        protected int MinimumFloor
        {
            get { return _minimumFloor; }
            set
            {
                if (value < 0 || value == null) throw new ArgumentException("minimum floor");
                _minimumFloor = value;
            }
        }

        protected string Name
        {
            get { return _name; }
            set
            {
                if(string.IsNullOrEmpty(value)) throw new ArgumentException("name");
                _name = value;
            }
        }
        protected int NumberOfFloors
        {
            get { return _numberOfFloors; }
            set
            {
                if (value < 0 || value == null) throw new ArgumentException("number of floor");
                _numberOfFloors = value;
            }
        }

        protected int Speed
        {
            get { return _speed; }
            set
            {
                if (value <= 0 || value == null) throw new ArgumentException("speed");
                _speed = value;
            }
        }

        protected TimeSpan Ts
        {
            get { return _ts; }
            set { _ts = value; }
        }

        public Lift(Type typeOfLift, int maximumFloor, int minimumFloor, string name, int numberOfFloors, int speed)
        {
            _typeOfLift = typeOfLift;
            _modeOfLift = Mode.Rest;
            _floors = new List<Floor>();
            SetFloors();
            _actualFloor = 0;
            _maximumFloor = maximumFloor;
            _minimumFloor = minimumFloor;
            _name = name;
            _numberOfFloors = numberOfFloors;
            _speed = speed;
            _ts = new TimeSpan(_speed);
        }

        protected void SetFloors()
        {
            for(int i = _minimumFloor; i<_numberOfFloors;++i)
            {
                Floor f = new Floor(i);
                _floors.Add(f);
            }
        }
        protected void AddFloor()
        {
            int f = _floors.Count - 1;
            f++;
            Floor floor = new Floor(f);
            _floors.Add(floor);
        }

        protected void Removefloor(int n)
        {
            _floors.RemoveAt(n);
        }

        protected void ChangeMode(Mode m)
        {
            _modeOfLift = m;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            Lift lift = obj as Lift;
            if(NumberOfFloors == lift.NumberOfFloors && Name == lift.Name) return true;
            return false;
        }

        protected Mode GetMode()
        {
            return ModeOfLift;
        }

        protected virtual void SetCallingFloor(int cf)
        {
        }

    }
}
