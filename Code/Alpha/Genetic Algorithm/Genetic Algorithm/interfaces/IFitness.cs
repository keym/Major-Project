using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    interface IFitness
    {
        IChromosome[] Population
        {
            get;
            set;
        }

        ICipher Cipher
        {
            get;
            set;
        }

        IChromosome[] calcFitness();
        string generateCipherText (IChromosome c, ICipher cipher);
        double generateFitness(string ciphertext);
    }
}
