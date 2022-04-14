using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6GameTrueFalse
{
    public partial class FormMain : Form
    {
        private GameManager manager;
        /// <summary>
        /// Задача 6
        /// Игра "Верю - не верю"
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 8. C# Уровень 1. Программирование \"по-взрослому\"\n" +
                               "Задача 6. Игра \"Верю - не верю\".";
            manager = new GameManager();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            manager.SetForm(labelText, buttonGo, buttonTrue, buttonFalse);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            manager.GoGame();
            manager.SetForm(labelText, buttonGo, buttonTrue, buttonFalse);
        }

        private void buttonTrue_Click(object sender, EventArgs e)
        {
            manager.Answer(true);
            manager.SetForm(labelText, buttonGo, buttonTrue, buttonFalse);
        }

        private void buttonFalse_Click(object sender, EventArgs e)
        {
            manager.Answer(false);
            manager.SetForm(labelText, buttonGo, buttonTrue, buttonFalse);
        }
    }
}
