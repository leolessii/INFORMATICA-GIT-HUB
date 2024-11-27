using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderLift
{
    public class Floor
    {
        private int _floorNumber;

        public int FloorNumber
        {
            get { return _floorNumber; }
            set 
            {
                _floorNumber = value; 
            }
        }

        public Floor(int n)
        {
            _floorNumber = n;
        }

        public int CallLift()
        {
            return FloorNumber;
        }
    }
}
