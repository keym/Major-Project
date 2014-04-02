using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    interface IGenetics
    {
        Double MutationRate
        {
            get;
            set;
        }

        Double CrossoverRate
        {
            get;
            set;
        }

        IChromosome[] reproduce(IChromosome[] intermediate);
    }
}
