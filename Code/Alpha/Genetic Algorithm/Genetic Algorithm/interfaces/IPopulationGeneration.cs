using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
     interface IPopulationGenerator
    {
         IChromosome[] Population
         {
             get;
             set;
         }

         int PopSize
         {
             get;
             set;
         }

         int ChromosomeLength
         {
             get;
             set;
         }
        
         IChromosome[] GeneratePopulation();
    }
}
