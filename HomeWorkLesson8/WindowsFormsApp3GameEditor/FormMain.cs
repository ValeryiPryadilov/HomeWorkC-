using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3GameEditor
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Редактируемый список вопросов
        /// </summary>
        private TrueFalse data;
        /// <summary>
        /// Задача 3.
        /// а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок (не создана база
        /// данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
        /// б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические»
        /// улучшения на свое усмотрение.
        /// в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
        /// г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 8. C# Уровень 1. Программирование “по-взрослому.\n" +
                               "Задача 3. Приложение редактор вопросов игры верю - не верю.";
        }
        
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath, 
                Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!dialog.FileName.EndsWith(".xml"))
                    dialog.FileName += ".xml";
                data = new TrueFalse(dialog.FileName);
                data.Add("Пример вопроса", true);
                try
                {
                    data.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка создания нового файла.\n{exception.Message}");
                    return;
                }
                numericUpDownNumQuestion.Maximum = 1;
                numericUpDownNumQuestion.Minimum = 1;
                numericUpDownNumQuestion.Value = 1;
                textBoxQuestion.Text = data[(int)numericUpDownNumQuestion.Value - 1].Text;
                checkBoxTrueFalse.Checked = data[(int) numericUpDownNumQuestion.Value - 1].TrueFalse;
            }
        }
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath, 
                Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                data = new TrueFalse(dialog.FileName);
                try
                {
                    data.Load();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка открытия файла.\n{exception.Message}");
                    return;
                }
                numericUpDownNumQuestion.Maximum = data.Count;
                numericUpDownNumQuestion.Minimum = 1;
                numericUpDownNumQuestion.Value = 1;
                textBoxQuestion.Text = data[(int)numericUpDownNumQuestion.Value - 1].Text;
                checkBoxTrueFalse.Checked = data[(int) numericUpDownNumQuestion.Value - 1].TrueFalse;
            }
        }
        private void miSave_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            if (data.Count == 0)
                return;
            try
            {
                data.Save();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Ошибка сохранения в файл.\n{exception.Message}");
                return;
            }
        }
        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            if (data.Count == 0)
                return;
            SaveFileDialog dialog = new SaveFileDialog
            {
                InitialDirectory = Application.StartupPath, 
                Filter = "Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!dialog.FileName.EndsWith(".xml"))
                    dialog.FileName += ".xml";
                try
                {
                    data.FileName = dialog.FileName;
                    data.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Ошибка сохранения в файл.\n{exception.Message}");
                    return;
                }
            }
        }
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void numericUpDownNumQuestion_ValueChanged(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            if (data.Count == 0)
                return;
            textBoxQuestion.Text = data[(int)numericUpDownNumQuestion.Value - 1].Text;
            checkBoxTrueFalse.Checked = data[(int) numericUpDownNumQuestion.Value - 1].TrueFalse;
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            data.Add(string.Empty, false);
            numericUpDownNumQuestion.Maximum = data.Count;
            numericUpDownNumQuestion.Value = data.Count;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            if (data.Count <= 1)
            {
                MessageBox.Show("Нельзя удалить последний элемент в списке.", "Ошибка");
                return;
            }
            data.Remove((int)numericUpDownNumQuestion.Value - 1);
            numericUpDownNumQuestion.Maximum--;
        }

        private void buttonSaveQuest_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Пустой список вопросов. Создайте новый или откройте сохраненный список.", "Ошибка");
                return;
            }
            data[(int) numericUpDownNumQuestion.Value - 1].Text = textBoxQuestion.Text;
            data[(int) numericUpDownNumQuestion.Value - 1].TrueFalse = checkBoxTrueFalse.Checked;
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
    }
}
