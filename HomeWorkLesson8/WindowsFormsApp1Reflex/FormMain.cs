using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1Reflex
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Задача 1.
        /// С помощью рефлексии выведите все свойства структуры DateTime
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 8. C# Уровень 1. Программирование “по-взрослому.\n" +
                               "Задача 1. С помощью рефлексии выведите все свойства структуры DateTime.";
            textBoxResult.Text = GetAllPropForType(typeof(DateTime));
        }

        private string GetAllPropForType(Type type)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("Открытые поля:");
            foreach (var item in type.GetFields())
            {
                builder.AppendLine(item.ToString());
            }
            builder.AppendLine();

            builder.AppendLine("Открытые свойства:");
            foreach (var item in type.GetProperties())
            {
                builder.AppendLine(item.ToString());
            }
            builder.AppendLine();

            builder.AppendLine("Открытые методы:");
            foreach (var item in type.GetMethods())
            {
                builder.AppendLine(item.ToString());
            }
            builder.AppendLine();
            builder.AppendLine();
            builder.AppendLine();
            builder.AppendLine("Все открытые члены:");
            foreach (var item in type.GetMembers())
            {
                builder.AppendLine(item.ToString());
            }
            builder.AppendLine();


            return builder.ToString();
        }
    }
}
