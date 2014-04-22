using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Genetic_Algorithm
{
    class SubGenetics: IGenetics
    {
        public double MutationRate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double CrossoverRate
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public SubGenetics(double crossRate, double mutRate, int Crossover, int Mutation)
        {
            CrossoverRate = crossRate;
            MutationRate = mutRate;
        }

        public IChromosome[] reproduce(IChromosome[] intermediate)
        {
            throw new NotImplementedException();
        }
    }
}
