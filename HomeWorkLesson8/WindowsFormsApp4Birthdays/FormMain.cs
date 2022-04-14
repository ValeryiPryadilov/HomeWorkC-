using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4Birthdays
{
    public partial class FormMain : Form
    {
        private Birthdays birthdays;
        /// <summary>
        /// Задача 4
        /// *Используя полученные знания и класс TrueFalse в качестве шаблона, разработать
        /// собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка,
        /// Английские слова и другие).
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 8. C# Уровень 1. Программирование “по-взрослому.\n" +
                               "Задача 4. Собственная утилита хранения Дней рождения.";
        }
        /// <summary>
        /// Кнопка добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            birthdays.Add(textBoxSurname.Text, textBoxName.Text, dateTimePickerBirthday.Value);
            PutStringsToListBox(birthdays.GetStrings(), listBoxList);
        }
        /// <summary>
        /// Кнопка редактировать
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                birthdays.Edit(listBoxList.SelectedIndex, textBoxSurname.Text, textBoxName.Text, dateTimePickerBirthday.Value);
                PutStringsToListBox(birthdays.GetStrings(), listBoxList);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка редактирования этой даты рождения\n" + exception.Message);
            }
        }
        /// <summary>
        /// Кнопка удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                birthdays.Delete(listBoxList.SelectedIndex);
                PutStringsToListBox(birthdays.GetStrings(), listBoxList);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка удаления даты рождения\n" + exception.Message);
            }
        }
        /// <summary>
        /// Выбор другого элемента на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).Enabled)
                PutDataToDetailPanel(birthdays, ref listBoxList, ref textBoxSurname, ref textBoxName, ref dateTimePickerBirthday);
        }
        /// <summary>
        /// Вставка данных в строковой список на форме
        /// </summary>
        /// <param name="strs"></param>
        /// <param name="listBox"></param>
        static void PutStringsToListBox(string[] strs, ListBox listBox)
        {
            listBox.Enabled = false;
            int selected = listBox.SelectedIndex;
            listBox.Items.Clear();
            listBox.Items.AddRange(strs);
            if (selected > strs.Length - 1)
                selected = strs.Length - 1;
            listBox.SelectedIndex = selected;
            listBox.Enabled = true;
        }
        /// <summary>
        /// Вставка данных в детальную панель
        /// </summary>
        /// <param name="birthdays"></param>
        /// <param name="listBox"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="dateTimePicker"></param>
        static void PutDataToDetailPanel(Birthdays birthdays, ref ListBox listBox, ref TextBox surname, ref TextBox name, ref DateTimePicker dateTimePicker)
        {
            Debug.WriteLine("debug detail panel");
            int select = listBox.SelectedIndex;
            if (select != -1)
            {
                var (surnam, nam, birthd) = birthdays[select];
                surname.Text = surnam;
                name.Text = nam;
                dateTimePicker.Value = birthd;
            }
        }
        /// <summary>
        /// Первый показ формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Shown(object sender, EventArgs e)
        {
            try
            {
                birthdays = new Birthdays();
                birthdays.Load();
            }
            catch (ApplicationException exception)
            {
                MessageBox.Show("Ошибка при загрузке файла дней рождений:\n" + exception.Message +
                                "\nДальнейшая работа программы невозможна");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка программы:\n" + exception.Message +
                                "\nДальнейшая работа программы невозможна");
                this.Close();
            }
            PutStringsToListBox(birthdays.GetStrings(), listBoxList);
            PutDataToDetailPanel(birthdays, ref listBoxList, ref textBoxSurname, ref textBoxName, ref dateTimePickerBirthday);
        }
        /// <summary>
        /// Сохранение дней рождений в файле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            birthdays.Save();
        }
    }
}
