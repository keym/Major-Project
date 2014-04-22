using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genetic_Algorithm
{
    class SubGenetics: IGenetics
    {
        private double mutationRate;
        private double crossoverRate;
        private int crossoverType;
        private int mutationType;

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

        public SubGenetics(double crossRate, double mutRate, int Crossover, int Mutation)
        {
            CrossoverRate = crossRate;
            MutationRate = mutRate;
            crossoverType = Crossover;
            mutationType = Mutation;
        }

        public IChromosome[] reproduce(IChromosome[] intermediate)
        {
            Random Rand = new Random();
            IMutation mutator;
            ICrossover crossover;

            switch (this.mutationType)
            {
                case 0:
                    mutator = new SubSingleMutation();
                    break;
                case 1:
                    MutationRate = 1;
                    mutator = new SubMultiMutation();
                    break;
                default:
                    mutator = null;
                    break;
            }

            switch (this.crossoverType)
            {
                case 0:
                    crossover = new SinglePointCrossover();
                    break;
                case 1:
                    crossover = new DualPointCrossover();
                    break;
                default:
                    crossover = null;
                    break;
            }

            int count = 0;
            int next;

            foreach (IChromosome c in intermediate)
            {
                int value = Rand.Next(0, 10);
                if (!c.Elite)
                {
                    if (0.1 * value < crossoverRate)
                    {
                        if (count > intermediate.Length)
                        {
                            next = 0;
                        }
                        else
                        {
                            next = count;
                        }

                        IChromosome[] generation = crossover.evolve(c, intermediate[next]);
                        intermediate[count] = generation[1];
                        if (count == 0)
                        {
                            intermediate[intermediate.Length - 1] = generation[0];
                        }
                        else
                        {
                            intermediate[count - 1] = generation[0];
                        }
                    }
                }
                count ++;
            }
            count = 0;
            foreach (IChromosome c in intermediate)
            {
                if (!c.Elite)
                {
                    int value = Rand.Next(0, 10);
                    if (0.1 * value < mutationRate)
                    {
                        intermediate[count] = mutator.mutate(c);
                    }
                }
                count++;
            }
            
            return intermediate;
        }
    }
}
