using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class SubPopGen : IPopulationGenerator
    {
        private int popSize;
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
                return popSize;
            }
            set
            {
                popSize = value;
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
            Population = new Chromosome[PopSize];
            char[] values = new char[ChromosomeLength];

            for (int i = 0; i < PopSize; i++)
            {
                values = Randomize();
                Population[i] = new Chromosome(0, values);
            }

            return Population;
        }

        private char[] Randomize()
        {
            Random Rand = new Random();

            char[] key = new char[26];
            key[0] = 'a';
            key[1] = 'b';
            key[2] = 'c';
            key[3] = 'd';
            key[4] = 'e';
            key[5] = 'f';
            key[6] = 'g';
            key[7] = 'h';
            key[8] = 'i';
            key[9] = 'j';
            key[10] = 'k';
            key[11] = 'l';
            key[12] = 'm';
            key[13] = 'n';
            key[14] = 'o';
            key[15] = 'p';
            key[16] = 'q';
            key[17] = 'r';
            key[18] = 's';
            key[19] = 't';
            key[20] = 'u';
            key[21] = 'v';
            key[22] = 'w';
            key[23] = 'x';
            key[24] = 'y';
            key[25] = 'z';

            for (int i = key.Length -1 ; i > 0; i--)
            {
                int j = Rand.Next(0, key.Length);
                char swap = key[i];
                key[i] = key[j];
                key[j] = swap;
            }

            return key;
        }
    }
}
