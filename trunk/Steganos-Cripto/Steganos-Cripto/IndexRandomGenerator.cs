using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Steganos_Cripto
{
    class IndexRandomGenerator
    {
        int size = 0;
        Random rnd = null;
        List<int> usedIndex = null;

        public IndexRandomGenerator(int seed, int size)
        {
            usedIndex = new List<int>();
            rnd = new Random(seed);
            this.size = size;
        }

        public int generateUnusedIndex()
        {
            int index;
            do
            {
                index = rnd.Next(size);
            }
            while (usedIndex.Contains(index));

            usedIndex.Add(index);

            return index;
        }
    }
}
