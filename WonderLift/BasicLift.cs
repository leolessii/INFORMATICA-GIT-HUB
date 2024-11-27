using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonderLift
{
    public class BasicLift : Lift
    {
        public BasicLift(Type typeOfLift, int maximumFloor, int minimumFloor, string name, int numberOfFloors, int speed) : base(typeOfLift, maximumFloor, minimumFloor, name, numberOfFloors, speed)
        {

        }
        protected virtual void SetCallingFloor(int cf)
        {
            int nFloorsToMove = Math.Abs(cf) + ActualFloor;
            if (cf < ActualFloor)
            {
                ChangeMode(Mode.Down);
                TimeSpan tsf = new TimeSpan(nFloorsToMove * Convert.ToInt32(_ts));
                _t = new PeriodicTimer(tsf);
                ValueTask<bool> b = new ValueTask<bool>(true);
                if (_t.WaitForNextTickAsync() == b)
                {
                    ChangeMode(Mode.Rest);
                }
            }
            else if (cf > ActualFloor)
            {
                ChangeMode(Mode.Up);
                TimeSpan tsf = new TimeSpan(nFloorsToMove * Convert.ToInt32(_ts));
                _t = new PeriodicTimer(tsf);
                ValueTask<bool> b = new ValueTask<bool>(true);
                if (_t.WaitForNextTickAsync() == b)
                {
                    ChangeMode(Mode.Rest);
                }
            }
        }
    }
}
