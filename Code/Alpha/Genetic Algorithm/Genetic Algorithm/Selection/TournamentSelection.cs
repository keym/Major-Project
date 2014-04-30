using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genetic_Algorithm
{
    class TournamentSelection : ISelection
    {
        IChromosome[] population;
        IChromosome[] intermediate;
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

        public TournamentSelection(IChromosome[] population)
        {
            Population = population;
            Intermediate = new IChromosome[population.Length];
        }

        public IChromosome[] selectAlleles()
        {
            IChromosome elite = population[0];
            population[0].Elite = false;

            foreach(IChromosome c in population)
            {
                if (c.Fitness > elite.Fitness)
                {
                    elite = c;
                }
            }

            intermediate[0] = elite;
            intermediate[0].Elite = true;


            for (int i = 1; i < Intermediate.Length; i++)
            {
                IChromosome[] tournement = new IChromosome[Convert.ToInt32(population.Length * 0.2)];

                Random Rand = new Random();

                for (int j = 0; j < tournement.Length; j++)
                {
                    tournement[j] = population[Rand.Next(0,population.Length)];
                }

                IChromosome winner = tournement[0];

                foreach(IChromosome c in tournement)
                {
                    if(c.Fitness > winner.Fitness)
                    {
                        winner = c;
                    } 
                }

                intermediate[i] = winner;
            }

            return intermediate;
        }
    }
}
