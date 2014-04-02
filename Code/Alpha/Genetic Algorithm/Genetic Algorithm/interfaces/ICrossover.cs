using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    interface ICrossover
    {
        IChromosome evolve(IChromosome alpha, IChromosome beta);
    }
}
