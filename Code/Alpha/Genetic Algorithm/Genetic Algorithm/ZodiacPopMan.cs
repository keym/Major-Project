using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class ZodiacPopMan : IPopulationManagement
    {
        private int chromosomeLength;
        private int populationSize;
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

        public ZodiacPopMan(int popSize, int chromoLength)
        {
            PopulationSize = popSize;
            ChromosomeLength = chromoLength;
        }

        public void Run()
        {
            Boolean terminate = false;
            DateTime Begin = DateTime.Now;

            IPopulationGenerator popGen = new ZodiacPopGen(PopulationSize, ChromosomeLength);
            Population = popGen.GeneratePopulation();
            ICipher cipher = new Z340Cipher();
            TimeTermination terminator = new TimeTermination();
            
            while (terminate == false)
            {
                IFitness fit = new NGramFitness(Population, cipher);
                Population = fit.calcFitness();

                ISelection selection = new RouletteSelection(Population);
                Intermediate = selection.selectAlleles();

                IGenetics genetics = new ZodiacGenetics(0.4, 0.1);
                genetics.reproduce(Intermediate);

                terminate = terminator.doesTerminate(Begin);
            }

            IChromosome best = findMaxFitness();
            String plaintext = generateCipherText(best, cipher);

            string output = best.ToString();
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"output.txt");
            file.WriteLine(output);
            file.WriteLine(plaintext);
            file.Close();

            finish();
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
            char[] ciphertext = new char[340];
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
        public void finish()
        {
            
        }
    }
}
