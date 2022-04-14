using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3TwoStrings
{
    class Program
    {
        /// <summary>
        /// Задача 3.
        /// *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        /// Например:
        /// badc являются перестановкой abcd.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 3. Определение что две строки являются перестановками или нет.");
            ///////////////////////////////////////////////////////////////////////////////////
            do
            {
                Write("Введите первую строку:> ");
                string s1 = ReadLine();
                Write("Введите вторую строку:> ");
                string s2 = ReadLine();
                if (s1.MySpecEquals(s2))
                {
                    WriteLine("Эти две строки являются строками - перестановками");
                }
                else
                {
                    WriteLine("Эти две строки не являются строками - перестановками");
                    Beep(500,500);
                }
                Write("Повторить? (y):> ");
            } while (ReadLine() == "y");
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }

    /// <summary>
    /// Класс специального сравнения строк
    /// </summary>
    static class SpecEquals
    {
        public static bool MySpecEquals(this string s1, string s2)
        {
            string str1 = string.Join("", s1.OrderBy(c => c).ToArray());
            string str2 = string.Join("", s2.OrderBy(c => c).ToArray());
            return str1.Equals(str2);
        }
    }
}
