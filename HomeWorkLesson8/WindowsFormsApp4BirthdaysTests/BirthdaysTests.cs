using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp4Birthdays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4Birthdays.Tests
{
    [TestClass()]
    public class BirthdaysTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Birthdays birthdays = new Birthdays(new List<BirthDay>()
            {
                new BirthDay {Surname = "Alex", Name = "Text", Birthday = new DateTime(1980,1,1)},
            });
            BirthDay test = new BirthDay { Surname = "Test", Name = "Test", Birthday = new DateTime(1981, 1, 1) };
            birthdays.Add(test.Surname, test.Name, test.Birthday);
            Assert.AreEqual(2, birthdays.Count);
            Assert.AreEqual(test, birthdays[1]);
        }

        [TestMethod()]
        public void EditTest()
        {
            Birthdays birthdays = new Birthdays(new List<BirthDay>()
            {
                new BirthDay {Surname = "Alex", Name = "Text", Birthday = new DateTime(1980,1,1)},
            });
            BirthDay test = new BirthDay { Surname = "Test", Name = "Test", Birthday = new DateTime(1981, 1, 1) };
            birthdays.Edit(0, test.Surname, test.Name, test.Birthday);
            Assert.AreEqual(1, birthdays.Count);
            Assert.AreEqual(test, birthdays[0]);
            Assert.ThrowsException<ApplicationException>(() => birthdays.Edit(2, test.Surname, test.Name, test.Birthday));
        }

        [TestMethod()]
        public void DeleteTest()
        {
            BirthDay test = new BirthDay { Surname = "Max", Name = "Faq", Birthday = new DateTime(1980, 1, 1) };
            Birthdays birthdays = new Birthdays(new List<BirthDay>()
            {
                new BirthDay {Surname = "Alex", Name = "Text", Birthday = new DateTime(1980,1,1)},
                test,
            });
            birthdays.Delete(0);
            Assert.AreEqual(1, birthdays.Count);
            Assert.AreEqual(test, birthdays[0]);
            Assert.ThrowsException<ApplicationException>(() => birthdays.Delete(2));
        }

        [TestMethod()]
        public void GetStringsTest()
        {
            Birthdays birthdays = new Birthdays(new List<BirthDay>()
            {
                new BirthDay {Surname = "Alex", Name = "Text", Birthday = new DateTime(1980,1,1)},
                new BirthDay { Surname = "Max", Name = "Faq", Birthday = new DateTime(1980, 1, 1) },
                new BirthDay { Surname = "Sax", Name = "Faq", Birthday = new DateTime(1980, 1, 1) },
            });
            string[] expected = {"Alex Text 1 января 1980 г.", "Max Faq 1 января 1980 г.", "Sax Faq 1 января 1980 г."};
            string[] test = birthdays.GetStrings();
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], test[i]);
            }
        }
    }
}