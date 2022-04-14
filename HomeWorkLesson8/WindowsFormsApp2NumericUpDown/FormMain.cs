using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2NumericUpDown
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Задача 2.
        /// Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown.
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 8. C# Уровень 1. Программирование “по-взрослому.\n" +
                               "Задача 2. Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown.";
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            textBoxNumber.Text = numericUpDownNumber.Text;
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            numericUpDownNumber.Text = textBoxNumber.Text;
        }
    }
}
