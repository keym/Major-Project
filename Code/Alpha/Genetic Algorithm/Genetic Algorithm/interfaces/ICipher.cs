using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    interface ICipher
    {
        int Length
        {
            get;
            set;
        }
        List<Array> Cipher
        {
            get;
            set;
        }
    }
}
