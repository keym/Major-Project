using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Genetic_Algorithm
{
    class PopMan : IPopulationManagement
    {
        private int chromosomeLength;
        private int populationSize;
        private int cipher;
        private int selection;
        private int fitness;
        private int timeLimit;
        private int mutation;
        private int crossover;

        private IChromosome[] Population;
        private IChromosome[] Intermediate;
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

        public int PopulationSize
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

        public PopMan(int popSize, int TimeLimit, int Cipher, int Fitness, int Selection, int Mutation, int Crossover)
        {
            PopulationSize = popSize;
            timeLimit = TimeLimit;
            cipher = Cipher;
            fitness = Fitness;
            selection = Selection;
            mutation = Mutation;
            crossover = Crossover;
        }

        public void Run()
        {
            Boolean terminate = false;
            DateTime Begin = DateTime.Now;
            ICipher Cipher;
            IPopulationGenerator popGen;
            IFitness fit;
            ISelection selection;
            IGenetics genetics;
            


            switch (this.cipher)
            {
                case 0:
                    ChromosomeLength = 0;
                    popGen = new SubPopGen(PopulationSize, ChromosomeLength);
                    Cipher = new SubstitutionCipher();
                    break;
                case 1: 
                    ChromosomeLength = 54;
                    popGen = new ZodiacPopGen(PopulationSize, ChromosomeLength);
                    Cipher = new Z408Cipher();
                    break;
                case 2:
                    ChromosomeLength = 63;
                    popGen = new ZodiacPopGen(PopulationSize, ChromosomeLength);
                    Cipher = new Z340Cipher();
                    break;
                default:
                    popGen = null;
                    Cipher = null;
                    break;
            }

            Population = popGen.GeneratePopulation();
            TimeTermination terminator = new TimeTermination(this.timeLimit);

            switch (this.fitness)
            {
                case 0:
                    fit = new NGramFitness(Population, Cipher);
                    break;
                case 1:
                    fit = new BiGramFitness(Population, Cipher);
                    break;
                case 2:
                    fit = new TriGramFitness(Population, Cipher);
                    break;
                case 3:
                    fit = new ReducedFitness(Population, Cipher);
                    break;
                default:
                    fit = null;
                    break;
            }

            while (terminate == false)
            {
                
                Population = fit.calcFitness();

                switch (this.selection)
                {
                    case 0: 
                        selection = new RouletteSelection(Population);
                        break;
                    case 1:
                        selection = new StochasticSelection(Population);
                        break;
                    case 2:
                        selection = new TournamentSelection(Population);
                        break;
                    default:
                        selection = null;
                        break;
                }
                Intermediate = selection.selectAlleles();

                switch (this.cipher)
                {
                    case 0: 
                        genetics = new SubGenetics(0.4, 0.1, this.crossover, this.mutation);
                        break;
                    case 1:
                        genetics = new ZodiacGenetics(0.4, 0.1, this.mutation, this.crossover);
                        break;
                    default:
                        genetics = null;
                        break;
                }

                genetics.reproduce(Intermediate);

                terminate = terminator.doesTerminate(Begin);

                IChromosome generationMax = findMaxFitness();
                Output(generationMax.Fitness.ToString());
            }

            IChromosome best = findMaxFitness();
            String plaintext = generateCipherText(best, Cipher);
            string output = best.ToString();

            
            Output(output);
            Output(plaintext);
        }

        private IChromosome findMaxFitness()
        {
            IChromosome best;

            best = Population[0];

            for(int i = 1; i<Population.Length-1; i++)
            {
                if (best.Fitness < Population[i].Fitness)
                {
                    best = Population[i];
                }
            }

            return best;
        }

        public string generateCipherText(IChromosome c, ICipher cipher)
        {
            char[] ciphertext = new char[cipher.Length];
            int i = 0;
            foreach (char allele in c.Alleles)
            {
                foreach (int letter in cipher.Cipher[i])
                {
                    ciphertext[letter - 1] = allele;

                }
                i++;
            }
            return new string(ciphertext);
        }

        public void Output(string output)
        {
            using (StreamWriter file = File.AppendText(@"output.txt"))
            {
                file.WriteLine(output);
            }
        }
    }
}
