using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(1);

            var randoms = new List<int>();

            for (var i = 0; i < 20; i++)
            {
                randoms.Add(random.Next(51));
            }

            var squaredRandoms = new List<int>();

            squaredRandoms.AddRange(randoms.Select(random => random * random));

            var oddNums = squaredRandoms.Where(random => random % 2 != 0);

            squaredRandoms.RemoveAll(squaredRandom => squaredRandom % 2 != 0);         
            
        }
    }
}
