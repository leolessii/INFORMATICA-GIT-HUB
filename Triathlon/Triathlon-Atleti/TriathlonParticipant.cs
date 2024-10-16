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

        public TriathlonParticipant(int swimTime, int bikeTime, string name, string lastName, string id) : base (name, lastName, id)
        {
            _swimTime=swimTime;
            _bikeTime=bikeTime;
        }

        public TriathlonParticipant(int swimTime, string name, string lastName, string id) : base(name, lastName, id)
        {
            _swimTime = swimTime;
            _bikeTime = null;
        }

        public TriathlonParticipant(string name, string lastName, string id) : base(name, lastName, id)
        {
            _swimTime = null;
            _bikeTime = null;
        }

        public override int? FinalResults()
        {
            return null;
        }

        public override ToString()
        {
            return $" Name: {TriathlonParticipant.Name}, Surname: {TriathlonParticipant.Surname}, Id: {TriathlonParticipant.Id}, Swim time: {TriathlonParticipant.SwimTime}, Bike Time: {TriathlonParticipant.BikeTime} ";
        }
    }
}
