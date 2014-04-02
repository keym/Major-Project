using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    interface IPopulationManagement
    {
        int ChromosomeLength
        {
            get;
            set;
        }

        int PopulationSize
        {
            get;
            set;
        }
        
        void Run();
        void finish();

    }
}
