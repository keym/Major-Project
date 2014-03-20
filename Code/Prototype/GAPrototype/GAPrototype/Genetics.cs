using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAPrototype
{
    class Genetics
    {
        private Double mutationRate;
        private Double crossoverRate;
        private Random Rand;

        public Genetics(Double CrossoverRate, Double MutationRate)
        {
            crossoverRate = CrossoverRate;
            mutationRate = MutationRate;
        }

        public Chromosome[] reproduce(Chromosome[] intermediate)
        {
            Rand = new Random();
            Crossover crossover = new Crossover();
            Mutation mutator = new Mutation();

            foreach (Chromosome c in intermediate)
            {
                int value = Rand.Next(0, 10);
                if (0.1 * value < crossoverRate)
                {
                    crossover.evolve(c, null);
                }
            }

            foreach (Chromosome c in intermediate)
            {
                int value = Rand.Next(0, 10);
                if (0.1 * value < mutationRate)
                {
                    mutator.mutate(c);
                }
            }

            return intermediate;
        }
    }
}
