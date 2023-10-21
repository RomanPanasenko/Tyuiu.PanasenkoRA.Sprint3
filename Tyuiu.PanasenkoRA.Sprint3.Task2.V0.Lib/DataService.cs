using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PanasenkoRA.Sprint3.Task2.V0.Lib
{
    public class DataService : ISprint3Task2V13
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double Ms = 0;
            int i = 1;
            value = 0.7;
            do
            {
                Ms = Ms + (Math.Pow(value, i) + (2 / (i + 1))) * Math.Sin(value);
                i++;
            } while (i <= 10);
            return Math.Round(Ms, 3);
        }
    }
}
