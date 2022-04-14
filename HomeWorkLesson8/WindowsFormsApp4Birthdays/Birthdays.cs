using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp4Birthdays
{
    /// <summary>
    /// Мастер по всем дням рождениям
    /// </summary>
    public class Birthdays
    {
        private List<BirthDay> list;
        private string fileName;
        public Birthdays(string fileName = @"birthdays.xml") : this(new List<BirthDay>(), fileName) { }
        public Birthdays(List<BirthDay> list, string fileName = @"birthdays.xml")
        {
            this.list = list;
            this.fileName = fileName;
        }
        /// <summary>
        /// Добавление нового дня рождения
        /// </summary>
        /// <param name="surname">фамилия</param>
        /// <param name="name">имя</param>
        /// <param name="birthday">день рождения</param>
        public void Add(in string surname, in string name, in DateTime birthday)
        {
            list.Add(new BirthDay()
            {
                Surname = surname ?? string.Empty,
                Name = name ?? string.Empty,
                Birthday = birthday,
            });
        }
        /// <summary>
        /// Редактирование дня рождения
        /// </summary>
        /// <param name="index">номер в списке</param>
        /// <param name="surname">фамилия</param>
        /// <param name="name">имя</param>
        /// <param name="birthday">день рождения</param>
        public void Edit(int index, in string surname, in string name, in DateTime birthday)
        {
            if (index < 0 || index > list.Count - 1)
                throw new ApplicationException("Индекс вне диапазона");
            BirthDay newest = new BirthDay
            {
                Surname = surname,
                Name = name,
                Birthday = birthday,
            };
            list[index] = newest;
        }
        /// <summary>
        /// Удаление одного дня рождения
        /// </summary>
        /// <param name="index"></param>
        public void Delete(int index)
        {
            if (index < 0 || index > list.Count - 1)
                throw new ApplicationException("Индекс вне диапазона");
            list.RemoveAt(index);
        }
        /// <summary>
        /// Получение списка всех дней рождений
        /// </summary>
        /// <returns></returns>
        public string[] GetStrings()
        {
            string[] strs = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                var (surname, name, birthday) = list[i];
                strs[i] = $"{surname} {name} {birthday.ToString("D")}";
            }
            return strs;
        }
        /// <summary>
        /// Индексатор по дням рождения
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public BirthDay this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
        public int Count => list.Count;
        /// <summary>
        /// Сохранение дней рождений в файле
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<BirthDay>));
            using (FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, list);
            }
        }
        /// <summary>
        /// Загрузка дней рождений из файла
        /// </summary>
        public void Load()
        {
            if (!new FileInfo(fileName).Exists) //ежли не найден файл - то его создание
            {
                if (MessageBox.Show("Файл дней рождений не найден, создать новый?", "Файл отстуствует", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Save();
                throw new ApplicationException("Нет файла данных!");
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<BirthDay>));
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                list = (List<BirthDay>)xmlSerializer.Deserialize(stream);
            }
        }
    }
    /// <summary>
    /// День рождения одного человека
    /// </summary>
    [Serializable]
    public struct BirthDay
    {
        [XmlAttribute]
        public string Surname { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public DateTime Birthday { get; set; }
        //public BirthDay() {}
        public void Deconstruct(out string surname, out string name, out DateTime birthday)
        {
            surname = Surname;
            name = Name;
            birthday = Birthday;
        }
    }
}
