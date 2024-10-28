using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triathlon_Atleti
{
    internal class RunSort: IComparer<TriathlonFinalist>
    {
        public int Compare(TriathlonFinalist? x, TriathlonFinalist? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return 1;
            if (y == null) return -1;
            if (x.RunTime < y.RunTime) return -1;
            if (x.RunTime > y.RunTime) return 1;
            return 0;
        }
    }
}
