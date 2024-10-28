using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlon_Atleti
{
    public class TriathlonParticipant : Athlete
    {
        protected int? _swimTime;
        protected int? _bikeTime;
        protected int? _prize;

        public int? SwimTime
        {
            get { return _swimTime; }
            set
            {
                _swimTime = value;
            }
        }

        public int? BikeTime
        {
            get { return _bikeTime; }
            set
            {
                _bikeTime = value;
            }
        }

        public int? Prize
        {
            get { return _prize; }
            set
            {
                _prize = value;
            }
        }

        public TriathlonParticipant(string name, string lastName, string id, int swimTime, int bikeTime) : base (name, lastName, id)
        {
            _swimTime=swimTime;
            _bikeTime=bikeTime;
            _prize = null;
        }

        public TriathlonParticipant(string name, string lastName, string id, int swimTime) : base(name, lastName, id)
        {
            _swimTime = swimTime;
            _bikeTime = null;
            _prize = null;
        }

        public TriathlonParticipant(string name, string lastName, string id) : base(name, lastName, id)
        {
            _swimTime = null;
            _bikeTime = null;
            _prize = null;
        }

        public override int? FinalResults()
        {
            return null;
        }

        public override string ToString()
        {
            return $" Name: {Name}, Surname: {Surname}, Id: {Id}, Swim time: {SwimTime}, Bike Time: {BikeTime} ";
        }
    }
}
