using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class SubMultiMutation : IMutation
    {
        public SubMultiMutation()
        {
        }

        public IChromosome mutate(IChromosome c)
        {
            Random Rand = new Random();

            for (int i = 0; i < c.Alleles.Length; i++)
            {
                if (Rand.Next(0, 100) < 5)
                {
                    int swap = Rand.Next(0, c.Alleles.Length);

                    char temp = c.Alleles[i];
                    c.Alleles[i] = c.Alleles[swap];
                    c.Alleles[swap] = temp;
                }
            }
            return c;
        }
    }
}
