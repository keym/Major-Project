using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAPrototype
{
    class Selection
    {
        private Chromosome[] population;
        private Chromosome[] intermediate;

        public Selection(Chromosome[] Population )
        {
            population = Population;
        }

        public Chromosome[] selectAlleles()
        {
            int maxfitness = 0;
            Random rand = new Random();

            foreach (Chromosome c in population)
            {
                maxfitness = maxfitness + c.Fitness;
            }


            return intermediate;
        }
    }
}
