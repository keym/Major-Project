using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class TimeTermination
    {
        public TimeTermination()
        {
        }

        public bool doesTerminate(DateTime begin)
        {
            DateTime Now = DateTime.Now;

            double length = Now.Subtract(begin).TotalMinutes;

            if (length > 2)
            {
                return true;
            }
            return false;
        }
    }
}
