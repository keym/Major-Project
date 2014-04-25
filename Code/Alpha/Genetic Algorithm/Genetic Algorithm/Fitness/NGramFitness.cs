using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Genetic_Algorithm
{
    class NGramFitness : IFitness
    {
        private IChromosome[] population;
        private ICipher cipher;
        private List<ngram> Search;

        public IChromosome[] Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }

        public ICipher Cipher
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

        public NGramFitness(IChromosome[] population, ICipher cipher)
        {
            Population = population;
            Cipher = cipher;
        }

        public IChromosome[] calcFitness()
        {
            readfiles();
            foreach (IChromosome c in Population)
            {
                string ciphertext = generateCipherText(c, Cipher);
                c.Fitness = generateFitness(ciphertext);
            }

            return Population;
        }

        public string generateCipherText(IChromosome c, ICipher cipher)
        {
            char[] ciphertext = new char[cipher.Length];
            int i = 0;
            foreach (char allele in c.Alleles)
            {
                if (i < Cipher.Cipher.Count)
                {
                    foreach (int letter in Cipher.Cipher[i])
                    {
                        ciphertext[letter - 1] = allele;

                    }
                    i++;
                }
            }
            return new string(ciphertext);
        }

        public double generateFitness(string ciphertext)
        {
            string copy = ciphertext;
            double fitness = 0;

            foreach (ngram s in Search)
            {
                double instances = (ciphertext.Length - copy.Replace(s.Search, "").Length) / s.Search.Length;

                fitness = fitness + (instances * s.Value);
            }

            return fitness;
        }

        public void readfiles()
        {
            int count = 0;
            double max2l = 1;
            double max3l = 1;
            Search = new List<ngram>();

            string data = Properties.Resources.count2l;
            string[] values = data.Split('\n');

            foreach (string s in values)
            {
                string[] ngrams = s.Split(',');

                if (count == 0)
                {
                    max2l = Convert.ToDouble(ngrams[1]);
                }

                Search.Add(new ngram(ngrams[0], Convert.ToDouble(ngrams[1]) / max2l));
                count++;
            }

            count = 0;
            data = Properties.Resources.count3l;
            values = data.Split('\n');

            foreach (string s in values)
            {
                string[] ngrams = s.Split(',');
                if (count == 0)
                {
                    max3l = Convert.ToDouble(ngrams[1]);
                }
                Search.Add(new ngram(ngrams[0], Convert.ToDouble(ngrams[1]) / max3l));
                count++;
            }

            Search.Add(new ngram("slaves", 10));
            Search.Add(new ngram("killing", 10));
            Search.Add(new ngram("kill", 10));
            Search.Add(new ngram("paradice", 10));
        }
    }
}
