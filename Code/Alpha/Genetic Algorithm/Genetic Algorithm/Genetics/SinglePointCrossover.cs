using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class SinglePointCrossover : ICrossover
    {
        public IChromosome[] evolve(IChromosome alpha, IChromosome beta)
        {
            IChromosome[] offspring = new IChromosome[2];
            offspring[0] = new ZodiacChromosome(0, new char[alpha.Alleles.Length]);
            offspring[1] = new ZodiacChromosome(0, new char[alpha.Alleles.Length]);

            int half = alpha.Alleles.Length/2;
            int count = 0;

            for (int i = 0; i < half; i++)
            {
                offspring[0].Alleles[i] = alpha.Alleles[i];
                count++;
            }

            for (int j = count; j < beta.Alleles.Length - 1; j++)
            {
                offspring[0].Alleles[j] = beta.Alleles[j];
            }

            for (int i = 0; i < half; i++)
            {
                offspring[1].Alleles[i] = beta.Alleles[i];
                count++;
            }

            for (int j = count; j < beta.Alleles.Length - 1; j++)
            {
                offspring[1].Alleles[j] = alpha.Alleles[j];
            }

            return offspring;
        }
    }
}
