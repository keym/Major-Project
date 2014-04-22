using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    interface IChromosome
    {
        double Fitness
        {
            get;
            set;
        }

        char[] Alleles
        {
            get;
            set;
        }

        bool Elite
        {
            get;
            set;
        }
    }
}
