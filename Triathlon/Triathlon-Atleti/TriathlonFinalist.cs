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

        public TriathlonFinalist(int swimTime, int bikeTime, int runTime, string name, string lastName, string id) : base(name, lastName, id)
        {
            _runTime = runTime;
        }

        public override int? FinalResults()
        {
            return SwimTime+BikeTime+RunTime;
        }

        public override ToString()
        {
            return $" Name: {TriathlonFinalist.Name}, Surname: {TriathlonFinalist.Surname}, Id: {TriathlonFinalist.Id}, Swim time: {TriathlonFinalist.SwimTime}, Bike Time: {TriathlonFinalist.BikeTime}, Run time {TriathlonFinalist.RunTime} ";
        }
    }
}
