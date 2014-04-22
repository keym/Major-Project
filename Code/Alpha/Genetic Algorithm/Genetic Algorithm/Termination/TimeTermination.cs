using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class TimeTermination
    {
        private int timeLimit;

        public int TimeLimit
        {
            get { return timeLimit; }
            set { timeLimit = value; }
        }
        public TimeTermination(int timeLimit)
        {
            TimeLimit = timeLimit;
        }

        public bool doesTerminate(DateTime begin)
        {
            DateTime Now = DateTime.Now;

            double length = Now.Subtract(begin).TotalMinutes;

            if (length > TimeLimit)
            {
                return true;
            }
            return false;
        }
    }
}
