using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GAPrototype
{
    class Fitness
    {
        private Chromosome[] Population;
        private Z340 Cipher;
        private Random r = new Random();
        private ngram[] Search;

        public Fitness(Chromosome[] population, Z340 cipher)
        {
            Population = population;
            Cipher = cipher;

            Search = new ngram[10];
            Search[0] = new ngram("th", 2);
            Search[1] = new ngram("he", 1);
            Search[2] = new ngram("in", 1);
            Search[3] = new ngram("er", 1);
            Search[4] = new ngram("an", 1);
            Search[5] = new ngram("ed", 1);
            Search[6] = new ngram("the", 5);
            Search[7] = new ngram("ing", 5);
            Search[8] = new ngram("and", 5);
            Search[9] = new ngram("eee", -5);
        }

        public Chromosome[] calcFitness()
        {
            foreach (Chromosome c in Population)
            {
                c.Fitness = generateFitness(generateCipherText(c));
            }

            return Population;
        }

        private string generateCipherText (Chromosome c)
        {
            char[] ciphertext = new char[340];

            foreach (char allele in c.Alleles)
            {
                int i = 0;
                foreach (int letter in Cipher.Cipher[i])
                {
                    ciphertext[letter-1] = allele;
                }
                i++;
            }
            return ciphertext.ToString();
        }

        private int generateFitness(string ciphertext)
        {
            string copy = ciphertext;
            int fitness = 0;

            foreach (ngram s in Search)
            {
                int instances = (ciphertext.Length - copy.Replace(s.Search, "").Length) / s.Search.Length;

                fitness = fitness + (instances * s.Value);
            }

            return fitness;
        }


        private class ngram
        {
            private string search;

            public string Search
            {
                get { return search; }
                set { search = value; }
            }
            private int value;

            public int Value
            {
                get { return this.value; }
                set { this.value = value; }
            }

            public ngram(string search, int value)
            {
                Search = search;
                Value = value;
            }
        }
    }
}
