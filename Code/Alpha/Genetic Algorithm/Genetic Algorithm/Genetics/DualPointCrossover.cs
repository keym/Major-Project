using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genetic_Algorithm
{
    class DualPointCrossover :ICrossover
    {
        public IChromosome[] evolve(IChromosome alpha, IChromosome beta)
        {
            IChromosome[] offspring = new IChromosome[2];
            offspring[0] = new Chromosome(0, new char[alpha.Alleles.Length]);
            offspring[1] = new Chromosome(0, new char[alpha.Alleles.Length]);

            int quarter = alpha.Alleles.Length / 4;
            int threequarter = quarter * 3;
            int count = 0;

            for (int i = 0; i < quarter; i++)
            {
                offspring[0].Alleles[i] = alpha.Alleles[i];
                count++;
            }

            for (int j = count; j < threequarter; j++)
            {
                offspring[0].Alleles[j] = beta.Alleles[j];
                count++;
            }

            for (int k = count; k < alpha.Alleles.Length - 1; k++)
            {
                offspring[0].Alleles[k] = alpha.Alleles[k];
            }

            count = 0;

            for (int i = 0; i < quarter; i++)
            {
                offspring[1].Alleles[i] = beta.Alleles[i];
                count++;
            }

            for (int j = count; j < threequarter; j++)
            {
                offspring[1].Alleles[j] = alpha.Alleles[j];
                count++;
            }

            for (int i = 0; i < beta.Alleles.Length - 1 ; i++)
            {
                offspring[1].Alleles[i] = beta.Alleles[i];
            }

            return offspring;
        }
    }
}
