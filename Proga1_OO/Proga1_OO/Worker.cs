using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga1_OO
{
    class Worker
    {
        double _value;
        double _rank;
        long _count;

        public Worker(double rank, double value = 1.1)
        {
            _rank = rank;
            _value = value;
        }

        public long GetValue()
        {
            return _count;
        }

        public void DoWork()
        {

            for (int i = 0; i < 1000000; i++)
            {
                Math.Pow(_value, _rank);
            }
            _count++;
        }
    }

}
