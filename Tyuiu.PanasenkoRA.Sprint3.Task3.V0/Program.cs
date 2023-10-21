using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PanasenkoRA.Sprint3.Task3.V0.Lib;

namespace Tyuiu.PanasenkoRA.Sprint3.Task3.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Панасенко Р. А. | ПКТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Панаcенко Роман Анатольевич | ПКТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву t в строке: 12able 1o    *");
            Console.WriteLine("* s4gh                                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "12able 1o s4gh";
            char item = 't';
            
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Символ, на который нужно заменить все цифры = " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Итоговая строка = " + ds.ReplaceNumOnChar(value, item));
            Console.ReadKey();
        }
    }
}
