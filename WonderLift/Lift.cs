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
        protected Type typeOfLift;
        protected Mode mode;
        protected int? initialFloor;
        protected int? maximumFloor;
        protected int? minimumFloor;
        protected string? name;
        protected int? numberOfFloors;
        protected double? speed;

        protected Type TypeOfLift
        {

        }
        protected int? InitialFloor
        {
            get { return initialFloor; }
            set 
            {
                if(value < 0 || value == null) throw new ArgumentException("initial floor");
                initialFloor = value; 
            }
        }

        protected int? MaximumFloor
        {
            get { return maximumFloor; }
            set
            {
                if (value < 0 || value == null) throw new ArgumentException("maximum floor");
                maximumFloor = value;
            }
        }

        protected int? MinimumFloor
        {
            get { return minimumFloor; }
            set
            {
                if (value < 0 || value == null) throw new ArgumentException("minimum floor");
                minimumFloor = value;
            }
        }

        protected string? Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value)) throw new ArgumentException("name");
                name = value;
            }
        }
        protected int? NumberOfFloors
        {
            get { return numberOfFloors; }
            set
            {
                if (value < 0 || value == null) throw new ArgumentException("number of floor");
                numberOfFloors = value;
            }
        }

        protected double? Speed
        {
            get { return speed; }
            set
            {
                if ((value < 0.0 || value == null) throw new ArgumentException("speed");
                speed = value;
            }
        }
    }
}
