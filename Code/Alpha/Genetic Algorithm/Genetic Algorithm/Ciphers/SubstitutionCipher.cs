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

            Length = 152;
            Cipher = new List<Array>();
            Cipher.Add(new int[] { 1, 12, 14, 16, 34, 37, 40, 58, 67, 73, 80, 82, 98, 110, 112, 127, 143 });
            Cipher.Add(new int[] { 2, 23, 35, 68, 81, 83, 99, 128, 149 });
            Cipher.Add(new int[] { 3, 5, 17, 21, 32 });
            Cipher.Add(new int[] { 4, 6, 8, 11, 30, 39, 70, 116 });
            Cipher.Add(new int[] { 7 });
            Cipher.Add(new int[] { 9, 15, 29, 93, 125 });
            Cipher.Add(new int[] { 10 });
            Cipher.Add(new int[] { 13, 41, 48, 59, 66, 79, 86, 95, 106, 113, 140, 147 });
            Cipher.Add(new int[] { 18, 27, 44, 52, 64, 71, 88, 114, 122, 132, 136 });
            Cipher.Add(new int[] { 19, 33, 42, 56, 96, 109, 115 });
            Cipher.Add(new int[] { 20, 50, 60, 94, 119, 135, 141, 146 });
            Cipher.Add(new int[] { 22, 47, 103, 117, 138, 148, });
            Cipher.Add(new int[] { 24, 31, 36, 38, 49, 51, 55, 57, 77, 84, 91, 100, 101, 104, 108, 120, 129, 134, 144, 150 });
            Cipher.Add(new int[] { 25, 28, 65, 76, 90, 105, 123, 126, 130, 133, 151 });
            Cipher.Add(new int[] { 26, 45, 53, 72, 89, 121, 124, 152 });
            Cipher.Add(new int[] { 43, 54, 63, 97 });
            Cipher.Add(new int[] { 46, 61, 75, 85, 111, 118, 142 });
            Cipher.Add(new int[] { 62, 139 });
            Cipher.Add(new int[] { 69, 87, 107, 131, 137 });
            Cipher.Add(new int[] { 74, 78 });
            Cipher.Add(new int[] { 92, 145 });
            Cipher.Add(new int[] { 102 });

        }
    }
}
