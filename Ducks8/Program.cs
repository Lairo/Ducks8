using System;
using System.Collections.Generic;

namespace Ducks8
{
    class Program
    {
        static void Main()
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = 0, Size = 17 },
                new Duck() { Kind = (KindOfDuck)1, Size = 18 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 13 },
            };

            IComparer<Duck> sizeComparer = new DuckComparerBySize();
            IComparer<Duck> kindComparer = new DuckComparerByKind();

            ducks.Sort(sizeComparer);
            PrintDucks(ducks);
            Console.WriteLine("\n");
            ducks.Sort(kindComparer);
            PrintDucks(ducks);
        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine($"{duck.Size} inch {duck.Kind}");
            }

        }

    }
}
