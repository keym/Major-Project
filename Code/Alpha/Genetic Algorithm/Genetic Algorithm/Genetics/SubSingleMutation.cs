using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class SubSingleMutation : IMutation
    {
        public SubSingleMutation()
        {
        }

        public IChromosome mutate(IChromosome c)
        {
            Random Rand = new Random();
            int allele = Rand.Next(0, c.Alleles.Length);
            int swap = Rand.Next(0, c.Alleles.Length);

            char temp = c.Alleles[allele];
            c.Alleles[allele] = c.Alleles[swap];
            c.Alleles[swap] = temp;

            return c;
        }
    }
}
