using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PanasenkoRA.Sprint3.Task1.V0.Lib
{
    public class DataService : ISprint3Task1V15
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MS = 0;
            int i = 1;
            value = 2;
            while (i < 6)
            {
                MS = MS + ((Math.Pow(value, 2) * i) + 1);
                i++;
            }
            return Math.Round(MS, 3);
        }
    }
}
