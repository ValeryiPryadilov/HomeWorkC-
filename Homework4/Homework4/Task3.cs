using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4


{
    class Program
    {
        /// <summary>Структура, содержащая Login и Password</summary>
        struct Account
        {
            public string Login;
            public string Password;

            /// <summary>Метод, считывающий логин и пароль из файла</summary>
            /// <param name="filename">Название файла</param>
            public static Account[] LoadFromFile(string filename)
            {

                StreamReader sr = new StreamReader(filename);

                Account[] buf = new Account[20];
                int counter = 0;

                while (!sr.EndOfStream)
                {

                    string Login = sr.ReadLine();

                    string Password = sr.ReadLine();
                    Account account = new Account();
                    account.Login = Login;
                    account.Password = Password;

                    buf[counter] = account;
                    counter++;

                }
                Account[] arr = new Account[counter];

                Array.Copy(buf, arr, counter);


                return arr;

            }

        }

       
        /// <summary>Метод поверяет корректность логина и пароля</summary>
        /// <param name="toCheck">Стурктура для проверки</param>
        /// <returns></returns>
        static bool CheckLogAndPass(Account toCheck)
        {
            if (toCheck.Login == "root" && toCheck.Password == "GeekBrains")
                return true;
            else
                return false;
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа проверки логина и пароля, считанных из файла.");
            

            string fileName = "Logins.txt" ;

            Console.WriteLine("\nЗагрузим файл: " + fileName);
            Account[] logins = Account.LoadFromFile(fileName);

            for (int i = 0; i < logins.Length; i++)

            {
               

                Console.Write("Попытка авторизации: ");

                if (CheckLogAndPass(logins[i]))
                {

                    break;
                }
                else
                {
                    
                    Console.WriteLine("Неверный ввод логина или пароля.");

                        
                }
                
            }

            Console.Write("Авторизация успешна!");

            Console.ReadKey();
        }



    }


}
