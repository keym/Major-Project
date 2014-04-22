using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class ZodiacPopGen : IPopulationGenerator
    {
        private IChromosome[] population;
        private int popSize;
        private int chromosomeLength;
        private Random R;

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

        public ZodiacPopGen(int popSize, int chromosomeLength)
        {
            PopSize = popSize;
            ChromosomeLength = chromosomeLength;
        }

        public IChromosome[] GeneratePopulation()
        {
            Population = new Chromosome[PopSize];
            char[] values = new char[ChromosomeLength]; ;
            R = new Random();

            for (int i = 0; i < PopSize; i++)
            {
                values = new char[ChromosomeLength];

                for (int j = 0; j < ChromosomeLength; j++)
                {
                    values[j] = GenerateValue();
                }

                Population[i] = new Chromosome(0, values);
            }

            return Population;
        }

        private char GenerateValue()
        {
            int val = R.Next(1, 27);
            switch (val)
            {
                case 1: return 'a';
                case 2: return 'b';
                case 3: return 'c';
                case 4: return 'd';
                case 5: return 'e';
                case 6: return 'f';
                case 7: return 'g';
                case 8: return 'h';
                case 9: return 'i';
                case 10: return 'j';
                case 11: return 'k';
                case 12: return 'l';
                case 13: return 'm';
                case 14: return 'n';
                case 15: return 'o';
                case 16: return 'p';
                case 17: return 'q';
                case 18: return 'r';
                case 19: return 's';
                case 20: return 't';
                case 21: return 'u';
                case 22: return 'v';
                case 23: return 'w';
                case 24: return 'x';
                case 25: return 'y';
                case 26: return 'z';
            }

            throw new Exception();
        }
    }
}
