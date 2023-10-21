using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PanasenkoRA.Sprint3.Task3.V0.Lib
{
    public class DataService : ISprint3Task3V6
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            value = "12able 1o s4gh";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    value = value.Replace(c, 't');
                }

            }
            return value;
        }
    }
}
