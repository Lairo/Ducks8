using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks8
{
    class Duck : IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck duckToCompare)
        {
            if (Size > duckToCompare.Size)
                return 1;
            if (Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"A {Size} inch {Kind}";
        }
    }
}
