using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2StaticClassMessage
{
    class Program
    {
        /// <summary>
        /// Задача 2.
        /// Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        /// а) Вывести только те слова сообщения,  которые содержат не более n букв.
        /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        /// в) Найти самое длинное слово сообщения.
        /// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        /// д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив
        /// слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        /// Здесь требуется использовать класс Dictionary.
        /// Рассахатский
        /// </summary>
        static void Main()
        {
            MyHelper.MyHeader(text: "Задача 2. Статический класс Message со статическими методами.");
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт А. Вывести только слова сообщения, которые содержат не более введенных букв.");
            Write("Введите сообщение:> ");
            string message = ReadLine();
            if (MyHelper.GetNumberFromConsole(out int minSize,
                "Ограничение на количество букв в словах сообщений (int)"))
            {
                WriteLine("Сообщение со словами с такими условиями:");
                string mutMessage = Message.GetWordsIfLength(message, minSize);
                WriteLine(mutMessage);
            }
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт Б. Удалить из сообщения слова, заканчиваемые на заданный символ.");
            if (MyHelper.GetNumberFromConsole(out char c,
                "Введите символ (char)"))
            {
                WriteLine("Сообщение без слов с такими условиями:");
                string mutMessage = Message.GetDelIfLastSymbol(message, c);
                WriteLine(mutMessage);
            }
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт В. Найти самое длинное слово сообщения.");
            WriteLine($"Это слово = {Message.GetMaxLengthWord(message)}");
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт Г. Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.");
            string messageLength = Message.GetMaxLengthWords(message);
            WriteLine("Сообщение из самых длинных слов:");
            WriteLine(messageLength);
            MyHelper.MyPause();
            ///////////////////////////////////////////////////////////////////////////////////
            WriteLine("Пункт Д. Частотный анализ текста.");
            string dictString = Message.GetDictionaryFrenqWords(message);
            WriteLine("Результаты анализа:");
            WriteLine(dictString);
            ///////////////////////////////////////////////////////////////////////////////////
            MyHelper.MyFooter();
        }
    }
}
