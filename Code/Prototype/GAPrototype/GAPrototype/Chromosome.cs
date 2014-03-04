using System;

namespace GAPrototype
{
	public class Chromosome
	{
		private int fitness;
		private Array<char> allels;

		public Array<char> Allels {
			get {
				return this.allels;
			}
			set {
				allels = value;
			}
		}

		public int Fitness {
			get {
				return this.fitness;
			}
			set {
				fitness = value;
			}
		}		
		public Chromosome (int ChromosomeLength)
		{
			allels = new Array<char>[ChromosomeLength];
			for(int i = 0; i<ChromosomeLength; i++)
			{
				Allels[i] = GenerateValue();
			}
		}
		
		
		private char GenerateValue()
		{
			Random rand = new Random();
			
			int val = rand.Next(1,27);
			switch(val)
			{
			case 1 : return 'a';
			case 2 : return 'b';
			case 3 : return 'c';
			case 4 : return 'd';
			case 5 : return 'e';
			case 6 : return 'f';
			case 7 : return 'g';
			case 8 : return 'h';
			case 9 : return 'i';
			case 10 : return 'j';
			case 11 : return 'k';
			case 12 : return 'l';
			case 13 : return 'm';
			case 14 : return 'n';
			case 15 : return 'o';
			case 16 : return 'p';
			case 17 : return 'q';
			case 18 : return 'r';
			case 19 : return 's';
			case 20 : return 't';
			case 21 : return 'u';
			case 22 : return 'v';
			case 23 : return 'w';
			case 24 : return 'x';
			case 25 : return 'y';
			case 16 : return 'z';
			}
		}
		
	}
}

