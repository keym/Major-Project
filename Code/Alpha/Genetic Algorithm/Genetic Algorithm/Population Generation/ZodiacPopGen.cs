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
        private int[] letterFrequencies;
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
            letterFrequencies = new int[26];
            letterFrequencies[0] = 8;
            letterFrequencies[1] = 1;
            letterFrequencies[2] = 3;
            letterFrequencies[3] = 4;
            letterFrequencies[4] = 13;
            letterFrequencies[5] = 2;
            letterFrequencies[6] = 2;
            letterFrequencies[7] = 6;
            letterFrequencies[8] = 7;
            letterFrequencies[9] = 0;
            letterFrequencies[10] = 1;
            letterFrequencies[11] = 4;
            letterFrequencies[12] = 2;
            letterFrequencies[13] = 7;
            letterFrequencies[14] = 8;
            letterFrequencies[15] = 2;
            letterFrequencies[16] = 0;
            letterFrequencies[17] = 6;
            letterFrequencies[18] = 6;
            letterFrequencies[19] = 9;
            letterFrequencies[20] = 3;
            letterFrequencies[21] = 1;
            letterFrequencies[22] = 2;
            letterFrequencies[23] = 0;
            letterFrequencies[24] = 2;
            letterFrequencies[25] = 0;

        }

        public IChromosome[] GeneratePopulation()
        {
            Population = new Chromosome[PopSize];
            char[] values = new char[ChromosomeLength]; ;
            R = new Random();

            for (int i = 0; i < PopSize; i++)
            {
                values = new char[ChromosomeLength];

                values = GenerateValues();

                Population[i] = new Chromosome(0, values);
            }

            return Population;
        }

        private char[] GenerateValues()
        {
            char[] values = new char[ChromosomeLength];
            double onepPer = (Convert.ToDouble(ChromosomeLength)/100);
            int[] noLetters = new int[26];

            for (int i = 0; i < 25; i++)
            {
                noLetters[i] = Convert.ToInt32(onepPer * letterFrequencies[i]);
            }
            int count = 0;
            foreach (int i in noLetters)
            {
                for (int j = 0; j < i; j++)
                {
                    switch(count)
                    {
                        case 0:
                            values[getRandom(values)] = 'a';
                            break;
                        case 1:
                            values[getRandom(values)] = 'b';
                            break;
                        case 2:
                            values[getRandom(values)] = 'c';
                            break;
                        case 3:
                            values[getRandom(values)] = 'd';
                            break;
                        case 4:
                            values[getRandom(values)] = 'e';
                            break;
                        case 5:
                            values[getRandom(values)] = 'f';
                            break;
                        case 6:
                            values[getRandom(values)] = 'g';
                            break;
                        case 7:
                            values[getRandom(values)] = 'h';
                            break;
                        case 8:
                            values[getRandom(values)] = 'i';
                            break;
                        case 9:
                            values[getRandom(values)] = 'j';
                            break;
                        case 10:
                            values[getRandom(values)] = 'k';
                            break;
                        case 11:
                            values[getRandom(values)] = 'l';
                            break;
                        case 12:
                            values[getRandom(values)] = 'm';
                            break;
                        case 13:
                            values[getRandom(values)] = 'n';
                            break;
                        case 14:
                            values[getRandom(values)] = 'o';
                            break;
                        case 15:
                            values[getRandom(values)] = 'p';
                            break;
                        case 16:
                            values[getRandom(values)] = 'q';
                            break;
                        case 17:
                            values[getRandom(values)] = 'r';
                            break;
                        case 18:
                            values[getRandom(values)] = 's';
                            break;
                        case 19:
                            values[getRandom(values)] = 't';
                            break;
                        case 20:
                            values[getRandom(values)] = 'u';
                            break;
                        case 21:
                            values[getRandom(values)] = 'v';
                            break;
                        case 22:
                            values[getRandom(values)] = 'w';
                            break;
                        case 23:
                            values[getRandom(values)] = 'x';
                            break;
                        case 24:
                            values[getRandom(values)] = 'y';
                            break;
                        case 25:
                            values[getRandom(values)] = 'z';
                            break;
                    }
                    
                }
                count++;
            }

            return values;
        }

        private int getRandom(char[] values)
        {
            int pos = R.Next(0, ChromosomeLength - 1);
            while (values[pos] != '\0')
            {
                if ((pos + 1) <= ChromosomeLength - 1)
                {
                    pos = pos + 1;
                }
                else
                {
                    pos = 0;
                }
            }
            return pos;
        }

    }
}
