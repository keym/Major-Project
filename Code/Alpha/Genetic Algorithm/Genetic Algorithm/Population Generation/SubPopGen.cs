using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class SubPopGen : IPopulationGenerator
    {
        private int populationSize;
        private int chromosomeLength;
        private IChromosome[] population;

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

        public int PopSize
        {
            get
            {
                return populationSize;
            }
            set
            {
                populationSize = value;
            }
        }

        public int ChromosomeLength
        {
            get
            {
                return chromosomeLength;
            }
            set
            {
                chromosomeLength = value;
            }
        }

        public SubPopGen(int populationSize, int chromosomeLength)
        {
            PopSize = populationSize;
            ChromosomeLength = chromosomeLength;
        }

        public IChromosome[] GeneratePopulation()
        {
            throw new NotImplementedException();
        }
    }
}
