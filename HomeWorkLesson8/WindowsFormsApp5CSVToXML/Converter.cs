using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp5CSVToXML
{
    static class Converter
    {
        /// <summary>
        /// Получение списка учеников из файла
        /// </summary>
        /// <param name="fileName">имя файла</param>
        /// <returns>список студентов и строка студентов</returns>
        public static (List<Student> students, string strs) GetListFromFile(string fileName)
        {
            List<Student> students = new List<Student>();
            StringBuilder builder = new StringBuilder();
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string str = reader.ReadLine();
                    string[] strs = str.Split(';');
                    students.Add(new Student()
                    {
                        FirstName = strs[0],
                        SecondName = strs[1],
                        University = strs[2],
                        Facility = strs[3],
                        Departament = strs[4],
                        Age = int.Parse(strs[5]),
                        Course = int.Parse(strs[6]),
                        Group = int.Parse(strs[7]),
                        City = strs[8]
                    });
                    builder.AppendLine(students.Last().ToString());
                }
            }
            return (students, builder.ToString());
        }
        /// <summary>
        /// Сохранение списка в файле XML
        /// </summary>
        /// <param name="students">список</param>
        /// <param name="fileName">имя файла</param>
        public static void SaveListToXMLFile(List<Student> students, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            using (FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, students);
            }
        }
    }
}
