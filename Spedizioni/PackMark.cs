using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spedizioni
{
    public class PackMark : Pack
    {
        public double mark;

        public double Mark
        {
            get { return mark; }
            private set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("the value can't be less than 0.0");
                }
                mark = value;
            }
        }

        public PackMark(double _mark, string id, string destination, DateOnly speditionDate, DateOnly deliveryDate, double weight, string city) : base(id, destination, speditionDate, deliveryDate, weight, city)
        {
            mark = _mark;
        }
    }
}
