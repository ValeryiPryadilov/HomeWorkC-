using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите номер задачи: ");
            int Number = int.Parse(Console.ReadLine());

            switch (Number)
            {
                case 1:

                    int minimumNum = Min3(332, 400, 213);
                    Console.WriteLine("332, 400, 213");
                    Console.Write("Минимальное из трех чисел: ");
                    Console.WriteLine(minimumNum);

                    Console.ReadLine();
                    break;
                case 2:

                    int Summa = SumNum(123456789);
                    Console.Write("Количество цифр: ");
                    Console.WriteLine("123456789");
                    Console.Write("количество цифр в числе: ");
                    Console.WriteLine(Summa);

                    Console.ReadLine();


                    break;
                case 3:
                    Console.WriteLine("Введите любое число, 0 заканчивает ввод:");

                    SumOdd();


                    break;
                case 4:

                    bool rezult = Log_In();
                    if (rezult == true)
                    {
                        Console.WriteLine("Добро пожаловать");
                    }
                    else
                    {
                        Console.WriteLine("Доступ запрещен");
                    }



                    Console.ReadLine();

                    break;
                case 5:
                    IMT();
                    break;

                default:
                    Console.WriteLine("Введите номер от 1 до 9.");
                    break;

            }

            Console.ReadKey();
        }

        /// <summary>
        /// 1. Написать метод, возвращающий минимальное из трех чисел
        /// </summary>
        /// <param name="a">целое</param>
        /// <param name="b">целое</param>
        /// <param name="c">целое</param>
        /// <returns>Возвращает минимальное из трех чисел</returns>
        static int Min3(int a, int b, int c)


        {

            if (a < b && a < c)
            {
                return a;

            }
            else if (b < c && b < a)
            {
                return b;

            }
            else
            {
                return c;



            }
        }

        /// <summary>
        /// 2. Написать метод подсчета количества цифр
        /// </summary>
        /// <param name="a">целое</param>
        /// <returns>Рассчитывает количество цифр в числе</returns>
        static int SumNum(int a)
        {
            int count = 0;
            while (a != 0)
            {
                a = a / 10;
                count++;
            }
            return count;
        }

        /// <summary>
        /// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        /// </summary>
        /// <returns>Сумма всех нечетных чисел.</returns>
        static void SumOdd()
        {
            int Sum = 0;
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                else if (a > 0 && a % 2 != 0)
                {
                    Sum += a;
                }
            }
            Console.Write("Сумма всех нечетных положительных чисел: ");
            Console.WriteLine(Sum);
        }

        /// <summary>
        /// 4.1. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь,
        /// если не прошел (логин: root, пароль: GeekBrains).
        /// </summary>
        /// <param name="login">логин: root </param>
        /// <param name="password">пароль: GeekBrains</param>
        /// <returns>true или false</returns>
        static bool verify(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                return true;

            }
            else
            {
                return false;

            }
        }

        /// <summary>
        /// 4.2. Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его
        /// дальше или не пропускает. С помощью цикла do while ограничивать ввод пароля 3 попытками.
        /// </summary>
        /// <returns>true или false</returns>
        static bool Log_In()
        {
            int count = 0;
            do
            {
                Console.Write("Логин: ");
                string login = Console.ReadLine();
                Console.Write("Пароль: ");
                string password = Console.ReadLine();
                count++;

                if (verify(login, password))
                {
                    return true;
                }
            } while (count < 3);
            return false;
        }

        /// <summary>
        /// 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет индекс массы тела и сообщает, нужно ли человеку
        /// похудеть или все в норме.
        /// б) Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. ИМТ в норме от 18,5 до 24,99. ИМТ = m/h^2
        /// </summary>
        static void IMT()
        {
            Console.Write("Рост, м: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вес, кг: ");
            double m = Convert.ToDouble(Console.ReadLine());
            double imt = m / (h * h);
            Console.WriteLine("ИМТ = {0:F3}", imt);

            if (imt < 18.5)
            {
                Console.WriteLine("Для идеального веса Вам нужно набрать: {0}", (18.5 - imt) * (h * h));
            }
            else if (imt > 24.99)
            {
                Console.WriteLine("Для идеального веса Вам нужно сбросить: {0}", (imt - 24.99) * (h * h));
            }
            else
            {
                Console.WriteLine("У вас идеальный вес");
            }
        }

    }

}





