using System;
using System.Collections.Generic;

namespace Benchmarks
{
    public static class Generator
    {
        public static IEnumerable<int> Get(int count)
        {
            var random = new Random();
            int current = 1;
            for (int i = 0; i <= count; i++)
            {
                if (random.Next(1, 4) % 2 == 0)
                {
                    yield return ++current;
                }
                else
                {
                    ++current;
                    yield return ++current;
                }
            }
        }
    }
}