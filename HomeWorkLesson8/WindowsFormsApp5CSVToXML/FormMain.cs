using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5CSVToXML
{
    public partial class FormMain : Form
    {
        List<Student> list = new List<Student>();
        /// <summary>
        /// Задача 5.
        /// **Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
        /// Рассахатский
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            labelHeader.Text = "Методичка 8. C# Уровень 1. Программирование \"по-взрослому\"\n" +
                               "Задача 5. Программа-преобразователь из CSV в XML-файл.";
        }

        private void buttonLoadFromCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = Application.StartupPath,
                Filter = "Файлы csv (*.csv)|*.csv|Все файлы (*.*)|*.*"
            };
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                var (tempList, strs) = Converter.GetListFromFile(dialog.FileName);
                list = tempList;
                textBoxData.Text = strs;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка чтения файла:\n" + exception.Message);
            }
        }

        private void buttonSaveToXML_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
                return;
            SaveFileDialog dialog = new SaveFileDialog()
            {
                InitialDirectory = Application.StartupPath,
                Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*",
            };
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                Converter.SaveListToXMLFile(list, dialog.FileName);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка записи в файл:\n" + exception.Message);
            }
        }
    }
}
