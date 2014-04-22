using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class ngram
    {
        private string search;

        public string Search
        {
            get { return search; }
            set { search = value; }
        }
        private double value;

        public double Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public ngram(string search, double value)
        {
            Search = search;
            Value = value;
        }
    }
 
}
