using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class StochasticSelection :  ISelection
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

        public StochasticSelection(IChromosome[] population)
        {
            Population = population;
            Intermediate = new IChromosome[population.Length];
        }

        public IChromosome[] selectAlleles()
        {
            IChromosome elite = population[0];
            foreach (IChromosome c in population)
            {
                if (c.Fitness > elite.Fitness)
                {
                    elite = c;
                }
            }

            intermediate[0] = elite;
            intermediate[0].Elite = true;

            double maxfitness = 0;
            double populationsize = Population.Length;
            Random Rand = new Random();

            foreach (IChromosome c in Population)
            {
                maxfitness = maxfitness + c.Fitness;
            }

            int PointerDistance = Convert.ToInt32(maxfitness / populationsize);

            int start = Rand.Next(0, PointerDistance);

            for (int i = 1; i < Intermediate.Length; i++)
            {
                double addedfit = 0;
                int count = 0;
                int choicefit = start * i;

                for (int j = 0; j < Intermediate.Length - 1; j++)
                {
                    addedfit += population[count].Fitness;
                    if (addedfit > choicefit)
                    {
                        count = j;
                        break;
                    }
                }
                intermediate[i] = population[count];
            }

            return intermediate;
        }
    }
}
