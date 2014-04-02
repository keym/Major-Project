using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    interface IMutation
    {
        IChromosome mutate(IChromosome c);
    }
}
