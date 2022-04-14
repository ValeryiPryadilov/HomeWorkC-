using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class ComplexV2
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        public double Re
        {
            get
            {
                return re;
            }

            set
            {
                re = value;
            }
        }

        public double Im
        {
            get
            {
                return im;
            }

            set
            {
                
                im = value;
            }
        }


        public ComplexV2()
        {

        }

        public ComplexV2(double newRe, double newIm)
        {
            
            im = newIm;
            re = newRe;

        }
        #region Сложение комплексных чисел
        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public ComplexV2 Plus(ComplexV2 complex)
        {

            // ComplexV2 newComplex = new ComplexV2(re + complex.re, im + complex.im);
            // newComplex.re = re + complex.re;
            // newComplex.im = im + complex.im;
            // return newComplex;
            return new ComplexV2(re + complex.re, im + complex.im);
        }

        public static ComplexV2 Plus(ComplexV2 complex1, ComplexV2 complex2)
        {
            ComplexV2 newComplex = new ComplexV2(complex1.re + complex2.re, complex1.im + complex2.im);
            //newComplex.re = complex1.re + complex2.re;
            //newComplex.im = complex1.im + complex2.im;
            return newComplex;
        }
        #endregion 

        #region Вычитание комплексных чисел
        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат вычитания комплексных чисел</returns>
        public ComplexV2 Minus(ComplexV2 complex)
        {

            
            return new ComplexV2(re - complex.re, im - complex.im);
        }

        public static ComplexV2 Minus(ComplexV2 complex1, ComplexV2 complex2)
        {
            ComplexV2 newComplex = new ComplexV2(complex1.re - complex2.re, complex1.im - complex2.im);
            
            return newComplex;
        }
        #endregion

        #region Произведение комплексных чисел
        /// <summary>
        /// Произведение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат произведения комплексных чисел</returns>
        public ComplexV2 Proiz(ComplexV2 complex)
        {


            return new ComplexV2(re * complex.re, im * complex.im);
        }

        public static ComplexV2 Proiz(ComplexV2 complex1, ComplexV2 complex2)
        {
            return new ComplexV2(complex1.re * complex2.re, complex1.im * complex2.im);

            
        }
        #endregion

        public override string ToString()
        {
            base.ToString();
            return $"{re} + {im}i";
        }

    }

    internal class Sample02
    {
        static void Main(string[] args)
        {
            ComplexV2 complex01 = new ComplexV2(2, 4);
            ComplexV2 complex02 = new ComplexV2(1, -5);

            //complex01.Im = 0;
            //complex01.Re = 5;

            //complex02.re = 0;


            ComplexV2 complex03 = complex02.Plus(complex01);

            Console.WriteLine($"Результат сложения комплексных чисел {complex01} и {complex02} : {complex03}");

            ComplexV2 complex04 = ComplexV2.Plus(complex02, complex01);

            Console.WriteLine($"Результат сложения комплексных чисел {complex01} и {complex02} : {complex04}");

            ComplexV2 complex05 = complex02.Minus(complex01);

            Console.WriteLine($"Результат вычитания комплексных чисел {complex02} и {complex01} : {complex05}");

            ComplexV2 complex06 = ComplexV2.Minus(complex02, complex01);

            Console.WriteLine($"Результат вычитания комплексных чисел {complex02} и {complex01} : {complex06}");

            ComplexV2 complex07 = complex02.Proiz(complex01);

            Console.WriteLine($"Результат произведения комплексных чисел {complex02} и {complex01} : {complex07}");

            ComplexV2 complex08 = ComplexV2.Proiz(complex02, complex01);

            Console.WriteLine($"Результат произведения комплексных чисел {complex02} и {complex01} : {complex08}");

            

            Console.WriteLine("введите re для первого числа");

            int re1 = int.Parse(Console.ReadLine());

            Console.WriteLine("введите im для первого числа");

            int im1 = int.Parse(Console.ReadLine());

            Console.WriteLine("введите re для второго числа");

            int re2 = int.Parse(Console.ReadLine());

            Console.WriteLine("введите im для второго числа");

            int im2 = int.Parse(Console.ReadLine());

            ComplexV2 chislo1 = new ComplexV2(re1, im1);
            ComplexV2 chislo2 = new ComplexV2(re2, im2);


            bool f = true;

            while (f)
            {
                


                Console.WriteLine("1 -> Сложение комплексных чисел");
                Console.WriteLine("2 -> Вычитание комплексных чисел");
                Console.WriteLine("3 -> Произведение комплексных чисел");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.Write("Введите номер : ");


                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        ComplexV2 summa1 = chislo2.Plus(chislo1);

                        Console.WriteLine($"Результат сложения комплексных чисел {chislo1} и {chislo2} : {summa1}");

                        ComplexV2 summa2 = ComplexV2.Plus(chislo2, chislo1);

                        Console.WriteLine($"Результат сложения комплексных чисел {chislo1} и {chislo2} : {summa2}");

                        break;
                    case 2:
                        ComplexV2 razno1 = chislo2.Minus(chislo1);

                        Console.WriteLine($"Результат вычитания комплексных чисел {chislo2} и {chislo1} : {razno1}");

                        ComplexV2 razno2 = ComplexV2.Minus(chislo2, chislo1);

                        Console.WriteLine($"Результат вычитания комплексных чисел {chislo2} и {chislo1} : {razno2}");
                        break;
                    case 3:
                        ComplexV2 ymnoz1 = chislo2.Proiz(chislo1);

                        Console.WriteLine($"Результат произведения комплексных чисел {chislo2} и {chislo1} : {ymnoz1}");

                        ComplexV2 ymnoz2 = ComplexV2.Proiz(chislo2, chislo1);

                        Console.WriteLine($"Результат произведения комплексных чисел {chislo2} и {chislo1} : {ymnoz2}");
                        break;
                    case 0:
                        Console.WriteLine("Завершение работы приложения.");
                        f = false;
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи. Повторите ввод");
                        break;
                }
            }



            Console.ReadLine();

        }
    }
}
