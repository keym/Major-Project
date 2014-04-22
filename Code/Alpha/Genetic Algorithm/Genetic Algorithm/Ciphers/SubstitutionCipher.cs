using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class SubstitutionCipher : ICipher
    {
        private List<Array> cipher;
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public List<Array> Cipher
        {
            get
            {
                return cipher;
            }
            set
            {
                cipher = value;
            }
        }

        public SubstitutionCipher()
        {

            Length = 0;
            Cipher = new List<Array>();

        }
    }
}
