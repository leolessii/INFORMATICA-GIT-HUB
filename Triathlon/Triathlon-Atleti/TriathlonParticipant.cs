using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlon_Atleti
{
    public class TriathlonParticipant : Athlete
    {
        protected int _swimTime;
        protected int _bikeTime;

        public int SwimTime
        {
            get { return _swimTime; }
            set
            {
                _swimTime = value;
            }
        }

        public int BikeTime
        {
            get { return _bikeTime; }
            set
            {
                _bikeTime = value;
            }
        }

        public TriathlonParticipant(int swimTime, int bikeTime, string name, string lastName, string id) : base (name, lastName, id)
        {
            _swimTime=swimTime;
            _bikeTime=bikeTime;
        }

        public TriathlonParticipant(int swimTime, string name, string lastName, string id) : base(name, lastName, id)
        {
            _swimTime = swimTime;
        }

        public TriathlonParticipant(string name, string lastName, string id) : base(name, lastName, id)
        {
        }

        public override int? FinalResults()
        {
            return null;
        }
    }
}
