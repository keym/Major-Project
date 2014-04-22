using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public class Chromosome : IChromosome
    {
        private double fitness;
        private char[] alleles;
        private bool elite;

        public bool Elite
        {
            get { return elite; }
            set { elite = value; }
        }

        public double Fitness
        {
            get
            {
                return fitness;
            }
            set
            {
                fitness = value;
            }
        }

        public char[] Alleles
        {
            get
            {
                return alleles;
            }
            set
            {
                alleles = value;
            }
        }

        public Chromosome(double fitness, char[] alleles)
        {
            Fitness = fitness;
            Alleles = alleles;
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
