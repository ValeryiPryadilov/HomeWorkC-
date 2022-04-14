using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp5CSVToXML
{
    /// <summary>
    /// Ученик
    /// </summary>
    [Serializable]
    public struct Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string University { get; set; }
        public string Facility { get; set; }
        public string Departament { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {SecondName} {University} {Facility} {Departament} {Age} {Course} {Group} {City}";
        }
    }
}
