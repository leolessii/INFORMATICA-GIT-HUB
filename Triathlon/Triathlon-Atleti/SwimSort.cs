using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlon_Atleti
{
    internal class SwimSort: IComparer<TriathlonParticipant>
    {
        public int Compare(TriathlonParticipant? x, TriathlonParticipant? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;
            if (x.SwimTime < y.SwimTime) return -1;
            if (x.SwimTime > y.SwimTime) return 1;
            return 0;
        }
    }
}
