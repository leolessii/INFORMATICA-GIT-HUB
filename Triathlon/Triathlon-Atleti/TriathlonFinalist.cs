using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlon_Atleti
{
    public class TriathlonFinalist : TriathlonParticipant
    {
        private int _runTime;

        public int RunTime
        {
            get { return _runTime; }
            set
            {
                _runTime = value;
            }
        }

        public TriathlonFinalist(string name, string lastName, string id, int swimTime, int bikeTime, int runTime) : base(name, lastName, id)
        {
            _runTime = runTime;
        }

        public override int? FinalResults()
        {
            return SwimTime+BikeTime+RunTime;
        }

        public override string ToString()
        {
            return $" Name: {Name}, Surname: {Surname}, Id: {Id}, Swim time: {SwimTime}, Bike Time: {BikeTime}, Run time {RunTime} ";
        }
    }
}
