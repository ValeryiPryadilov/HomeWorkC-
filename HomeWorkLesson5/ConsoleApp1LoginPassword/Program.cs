using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1LoginPassword
{
    class Program
    {
        /// <summary>
        /// Задача 1
        /// Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов,
        /// содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        /// а) без использования регулярных выражений;
        /// б) **с использованием регулярных выражений.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 1. Проверка корректности ввода логина. ");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт А. Без использования регулярных выражений.");
            if (GetLoginFromConsole(out string login, ValidNoRegex)) //ввод с консоли логина и сразу его проверка без регулярного выражения
            {
                WriteLine($"Введен корректный логин пользователя \"{login}\"");
            }
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт Б. C использованием регулярных выражений.");
            if (GetLoginFromConsole(out login, ValidWithRegex)) //ввод с консоли логина и сразу его проверка с регулярным выражением
            {
                WriteLine($"Введен корректный логин пользователя \"{login}\"");
            }            
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
        /// <summary>
        /// Ввод значения с консоли и сразу его проверка
        /// </summary>
        /// <param name="login"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        static bool GetLoginFromConsole(out string login, Func<string, bool> func)
        {
            while (true)
            {
                Write("Введите логин (q-отмена):> ");
                string buff = ReadLine();
                if (func(buff))
                {
                    login = buff;
                    return true;
                }
                if (buff == "q")
                {
                    login = string.Empty;
                    return false;
                }
                WriteLine("Введен неверный формал логина!");
                Beep(500, 500);
            }
        }
        /// <summary>
        /// Проверка логина без регулярного выражения
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        static bool ValidNoRegex(string login)
        {
            if (login.Length < 2 || login.Length > 10)
                return false;
            if (Char.IsDigit(login[0]))
                return false;
            for (int i = 0; i < login.Length; i++)
            {
                char c = char.ToLower(login[i]);
                if ( !(c >= 'a' && c <= 'z' || char.IsDigit(c)) )
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Проверка логина с регулярным выражением
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        static bool ValidWithRegex(string login)
        {
            Regex regex = new Regex(@"^[a-z][a-z\d]{1,9}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(login);
        }
    }
}
