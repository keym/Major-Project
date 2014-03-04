using System;
using System.Collections.Generic;


namespace GAPrototype
{
	public class PopulationGenerator
	{
		private Chromosome[] Population;
		private int popSize;
		private int chromosomeLength;
        private Random R = new Random();

		public int ChromosomeLength {
			get {
				return this.chromosomeLength;
			}
			set {
				chromosomeLength = value;
			}
		}

		public int PopSize {
			get {
				return this.popSize;
			}
			set {
				popSize = value;
			}
		}		
		public PopulationGenerator (int popSize, int chromosomeLength)
		{
            PopSize = popSize;
            ChromosomeLength = chromosomeLength;
		}
		
		public Chromosome[] GeneratePopulation()
		{
			Population = new Chromosome[popSize];
			for(int i = 0; i<ChromosomeLength; i++)
			{
				Population[i] = new Chromosome(ChromosomeLength, R);
			}

            return Population;
		}
	}
}

