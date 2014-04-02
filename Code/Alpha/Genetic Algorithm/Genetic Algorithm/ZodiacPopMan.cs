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

            ZodiacPopGen popGen = new ZodiacPopGen(PopulationSize, ChromosomeLength);
            Population = popGen.GeneratePopulation();
            Z340Cipher cipher = new Z340Cipher();
            TimeTermination terminator = new TimeTermination();
            
            while (terminate == false)
            {
                NGramFitness fit = new NGramFitness(Population, cipher);
                Population = fit.calcFitness();

                RouletteSelection selection = new RouletteSelection(Population);
                Intermediate = selection.selectAlleles();

                terminate = terminator.doesTerminate(Begin);
            }

            finish();
        }

        public void finish()
        {
            
        }
    }
}
