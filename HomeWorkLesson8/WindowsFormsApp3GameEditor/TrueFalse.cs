using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp3GameEditor
{
    //вопрос
    [Serializable]
    public class Question
    {
        //Текстовое поле
        public string Text { get; set; }
        //Значение вопроса
        public bool TrueFalse { get; set; }
        public Question(string text, bool trueFalse)
        {
            Text = text;
            TrueFalse = trueFalse;
        }
        public Question() {}
    }
    //список с вопросами и вспомогательные инструменты
    public class TrueFalse
    {
        private string fileName;
        private List<Question> list;
        /// <summary>
        /// Установка файла содержащего конфу с вопросами
        /// </summary>
        public string FileName
        {
            set => fileName = value;
        }
        /// <summary>
        /// Создание списка вопросов и связи его с файлом
        /// </summary>
        /// <param name="fileName"></param>
        public TrueFalse(string fileName)
        {
            FileName = fileName;
            list = new List<Question>();
        }
        /// <summary>
        /// Добавление нового вопроса
        /// </summary>
        /// <param name="text"></param>
        /// <param name="trueFalse"></param>
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }
        /// <summary>
        /// Удаление элемента
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            if (list != null && index <= list.Count - 1 && index >= 0)
                list.RemoveAt(index);
        }
        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Question this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
        /// <summary>
        /// Количество элементов
        /// </summary>
        public int Count => list.Count;
        /// <summary>
        /// Сохранить в xml файл
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            FileInfo fileInfo = new FileInfo(fileName);
            if (fileInfo.Exists && fileInfo.IsReadOnly)
                throw new ApplicationException("Файл доступен только для чтения");
            using (FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, list);
            }
        }
        /// <summary>
        /// Открыть xml файл
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            FileInfo fileInfo = new FileInfo(fileName);
            if (!fileInfo.Exists)
                throw new ApplicationException("Файл не возможно открыть т.к. он не существует!");
            if (fileInfo.Length > 1024 * 1024)
                throw  new ApplicationException("Файл слишком большой для этой маленькой программы");
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                list = xmlSerializer.Deserialize(stream) as List<Question>;
            }
        }

    }


}
