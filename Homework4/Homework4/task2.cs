using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Homework4

 //   Реализуйте задачу 1 в виде статического класса StaticClass;
 // а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
 // б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать 
 //    массив целых чисел;
 
{
    public static class MyUtils
    {

        public static int[] LoadFromFile(string fileName)
        {
            
            try
            {
                StreamReader streamReader = new StreamReader(fileName);
                int[] buf = new int[1000];
                int counter = 0;

                while (!streamReader.EndOfStream)
                {
                    buf[counter] = int.Parse(streamReader.ReadLine());
                    counter++; 
                }

                int[] arr = new int[counter];

                Array.Copy(buf, arr, counter);

                return arr;
            }
            catch
            {
                Console.WriteLine("Произошла ошибка чтения файла. Завершение работы приложения.");
                return null;
            }
        }

        public static int DivBy3(string fileName)
        {
            int[] am = LoadFromFile(fileName);

            int count = 0;
            for (int i = 0; i < am.Length - 1; i++)
            {
                if (am[i] % 3 == 0 ^ am[i + 1] % 3 == 0)
                    count++;
                Console.WriteLine("Пара чисел: {0} и {1}", am[i], am[i + 1]);

            }
            Console.WriteLine("Количество пар: " + count);
            Console.ReadLine();
            return count;

        }

        internal static void PrintArr(object arr)
        {
            throw new NotImplementedException();
        }
    }

    class Task2
    {
        static void Main(string[] args)
        {
            MyUtils.DivBy3(AppDomain.CurrentDomain.BaseDirectory + "TextFile1.txt");

            Console.ReadLine();

                   }
    }

    public class Task02
    {
        private int[] am;

        public Task02(int n, int min, int max)
        {
            am = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                am[i] = random.Next(min, max);

        }

        public int[] ReadArrayFromFile(string fileName)
        {
            int[] retArr;
            try
            {
                retArr = File.ReadLines(fileName).Select(l => Convert.ToInt32(l)).ToArray();
            }
            catch (Exception ex)
            {
                retArr = new int[0];
                Console.WriteLine($"File {fileName} not found. {ex}");
            }
            return retArr;


        }



    }

}


