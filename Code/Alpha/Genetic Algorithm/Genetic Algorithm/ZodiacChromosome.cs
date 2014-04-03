using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public class ZodiacChromosome : IChromosome
    {
        private double fitness;
        private char[] alleles;

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

        public ZodiacChromosome(double fitness, char[] alleles)
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
