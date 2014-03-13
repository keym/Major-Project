using System;

namespace GAPrototype
{
	public class Chromosome
	{
		private int fitness;
		private char[] alleles;
        private Random Rand;

		public char[] Alleles {
			get {
				return this.alleles;
			}
			set {
				alleles = value;
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
		public Chromosome (char[] values)
		{
            alleles = values;
            Fitness = 0;
		}
		

        public override string ToString()
        {
            string ret = "";
            for (int i = 0; i < Alleles.Length; i++)
            {
                ret += Alleles[i];
            }

            ret += " ";
            ret += fitness;
            ret += "\n";
            return ret;
        }
	}
}

