using System;

namespace GAPrototype
{
	public class Chromosome
	{
		private int fitness;
		private char[] allels;
        private Random Rand;

		public char[] Allels {
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
		public Chromosome (int ChromosomeLength, Random rand)
		{
            Rand = rand;
			allels = new char[ChromosomeLength];
			for(int i = 0; i<ChromosomeLength; i++)
			{
				Allels[i] = GenerateValue();
			}
		}
		
		
		private char GenerateValue()
		{
    		int val = Rand.Next(1,27);
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
			case 26 : return 'z';
			}

            throw new Exception();
		}

        public override string ToString()
        {
            string ret = "";
            for (int i = 0; i < Allels.Length; i++)
            {
                ret += Allels[i];
            }

            ret += " ";
            ret += fitness;
            ret += "\n";
            return ret;
        }
	}
}

