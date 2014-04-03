using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class RouletteSelection : ISelection
    {
        private IChromosome[] population;
        private IChromosome[] intermediate;
        public IChromosome[] Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }

        public IChromosome[] Intermediate
        {
            get
            {
                return intermediate;
            }
            set
            {
                intermediate = value;
            }
        }

        public RouletteSelection(IChromosome[] population)
        {
            Population = population;
            Intermediate = new IChromosome[population.Length];
        }
        public IChromosome[] selectAlleles()
        {
            double maxfitness = 0;
            Random rand = new Random();

            foreach (IChromosome c in Population)
            {
                maxfitness = maxfitness + c.Fitness;
            }

            for(int i = 0; i < Intermediate.Length; i++)
            {
                int choicefit = rand.Next(0, Convert.ToInt32(maxfitness));
                double addedfit = 0;
                int count = 0;

                for (int j = 0; j < Intermediate.Length-1; j++)
                {
                    addedfit += population[count].Fitness;
                    if (addedfit > choicefit)
                    {
                        count= j;
                        break;
                    }
                }
                intermediate[i] = population[count];
            }

            return intermediate;
        }
    }
}
