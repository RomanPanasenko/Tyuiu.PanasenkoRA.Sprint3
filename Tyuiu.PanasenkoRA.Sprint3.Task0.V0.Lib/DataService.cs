using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PanasenkoRA.Sprint3.Task0.V0.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MS = 0;
            int i;

            for (i = startValue; i <= stopValue; i++)
            {
                MS = MS + (i / (Math.Pow((Math.Sin(1)), -10)));
            }
            return Math.Round(MS, 3);
        }
    }
}
