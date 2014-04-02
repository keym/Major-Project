using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class ZodiacGenetics : IGenetics
    {
        private double mutationRate;
        private double crossoverRate;

        public double MutationRate
        {
            get
            {
                return mutationRate;
            }
            set
            {
                mutationRate = value;
            }
        }

        public double CrossoverRate
        {
            get
            {
                return crossoverRate;
            }
            set
            {
                crossoverRate = value;
            }
        }

        public ZodiacGenetics(double crossRate, double mutRate)
        {
            CrossoverRate = crossRate;
            MutationRate = mutRate;
        }
        public IChromosome[] reproduce(IChromosome[] intermediate)
        {
            Random Rand = new Random();
            SinglePointCrossover crossover = new SinglePointCrossover();
            SingleMutation mutator = new SingleMutation();

            foreach (IChromosome c in intermediate)
            {
                int value = Rand.Next(0, 10);
                if (0.1 * value < crossoverRate)
                {
                    crossover.evolve(c, null);
                }
            }

            foreach (IChromosome c in intermediate)
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
