using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    struct Complex
    {
        
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        #region Сложение комплексных чисел
        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат сложения комплексных чисел</returns>
        public Complex Plus(Complex complex)
        {

            Complex newComplex;
            newComplex.re = re + complex.re;
            newComplex.im = im + complex.im;
            return newComplex;
        }

        public static Complex Plus(Complex complex1, Complex complex2)
        {
            Complex newComplex;
            newComplex.re = complex1.re + complex2.re;
            newComplex.im = complex1.im + complex2.im;
            return newComplex;
        }
        #endregion

        #region Вычитание комплексных чисел
        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="complex">Комплексное число</param>
        /// <returns>Результат вычитания комплексных чисел</returns>
        public Complex Minus(Complex complex)
        {

            Complex newComplex;
            newComplex.re = re - complex.re;
            newComplex.im = im - complex.im;
            return newComplex;
        }

        public static Complex Minus(Complex complex1, Complex complex2)
        {
            Complex newComplex;
            newComplex.re = complex1.re - complex2.re;
            newComplex.im = complex1.im - complex2.im;
            return newComplex;
        }
        #endregion

        public override string ToString()
        {
            base.ToString();
            return $"{re} + {im}i";



        }

    }



    internal class Task1A
    {
        static void Main(string[] args)
        {
            
            Complex complex01;
            complex01.re = 2;
            complex01.im = 3;

            Complex complex02;
            complex02.re = 0;
            complex02.im = -2;

            
            Complex complex03 = complex02.Minus(complex01);

            Console.WriteLine($"Результат вычитания комплексных чисел {complex02} и {complex01} : {complex03}");

            Complex complex04 = Complex.Minus(complex02, complex01);

            Console.WriteLine($"Результат вычитания комплексных чисел {complex02} и {complex01} : {complex04}");

            //Complex complex05 = complex01 - complex02;



            Console.ReadLine();

        }
    }
}
