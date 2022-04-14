using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class ComplexV3
    {
        static void Main(string[] args)
        {
            int i = 0;
            int summa = 0;
            List<int> Number = new List<int>();

            Console.WriteLine("вводите числа, пока не будет введен 0: ");
            


            do
            {
                bool flag = int.TryParse(Console.ReadLine(), out i);

                if (Control(flag) == false)
                {
                    i = -1;
                    continue;
                }

                if (i % 2 != 0 && i > 0)
                {
                    Number.Add(i);
                    summa += i;
                }
            } while (i != 0);

            Console.WriteLine("Нечетные положительные числа:");
            foreach (int item in Number) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Сумма всех нечетных положительных чисел: " + summa);
            Console.ReadKey();
        }

        static bool Control(bool flag)
        {
            if (flag == false)
            {
                Console.WriteLine("Ошибка при вводе данных. Повторите ввод.");
                return false;
            }
            return true;
        }
    }
}
