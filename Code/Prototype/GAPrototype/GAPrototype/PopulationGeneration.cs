using System;

namespace GAPrototype
{
	public class PopulationGenerator
	{
		private Array<Chromosome> Population;
		private int popSize;
		private int chromosomeLength;

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
		}
		
		private Array<Chromosome> GeneratePopulation ()
		{
			Population = new Array<Chromosome>[PopulationSize];
			for(int i = 0; i<ChromosomeLength; i++)
			{
				Population[i] = new Chromosome(ChromosomeLength);
			}
		}
	}
}

