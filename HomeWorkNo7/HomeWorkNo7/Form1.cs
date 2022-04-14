using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkNo7
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private int ComputerNumber;
        private string UserNumber;
        private int count;
        private int score;
        public Form1()
        {
            InitializeComponent();
        }

        private void confirmation_Click(object sender, EventArgs e)//Событие - Когда нажимаем ОК, привязанна к вводу чифр с помощью кнопок интерфейса
        {
            if(UserNumber == default && ComputerNumber != default)//Если пытаемся нажать ОК когда поле с цифрой пустое
            {
                MessageBox.Show("Сначала введите число!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (UserNumber != default)//Если игра начата и набранно наше число, то кнопка 'ОК' сработает
            {
                ImputNumber.Text = "";
                int a = int.Parse(UserNumber);

                if (a < ComputerNumber)//Если наше число меньше загаданного
                {
                    Hint.Location = new System.Drawing.Point(100, 120);
                    Hint.Text = $"Число {UserNumber} меньше загаданного!";
                    Count(1);//Отнимется одна попытка с помощью вызова этого метода
                    CheckOver();//Вызовется метод который проверит, а не проиграли ли мы
                    UserNumber = default;
                    UpdateMyNumber();//Не особо значимый метод, просто сделал обновление текста моего числа по умолчанию
                }
                else if (a > ComputerNumber)//Если наше число больше загаданного
                {
                    Hint.Location = new System.Drawing.Point(100, 120);
                    Hint.Text = $"Число {UserNumber} больше загаданного!";                    
                    Count(1);
                    CheckOver();
                    UserNumber = default;
                    UpdateMyNumber();
                }
                else if (a == ComputerNumber)//Если мы угадали число то:
                {
                    Hint.Location = new System.Drawing.Point(140, 120);
                    Hint.Text = "Вы угадали число!";
                    MessageBox.Show($"Полученно очков - {counting(count)}", "Вы угадали!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TableScore(count);//Посчитаются заработанные очки
                    ContinueGame();//И игра продолжится (т.е. начнется заново), с набранными очкими.
                }
            }
            else if (ComputerNumber == default)//Если грубо говоря игра не начата (число компьютера не сгенерированно), то кнопка 'ОК' не сработает
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
        }
        private int counting(int count)//Метод посчитает сколько очков мы набрали
        {
            //Работа цикла - чем меньше попыток мы потратили при угадывании числа,
            //то больше очков мы получим
            int f = 10;
            while (count != 10)
            {
                f--;
                count++;
            }
            f *= f;
            return f;
        }
        private void TableScore(int count)//Метод выведет на экран наши обновленные очки
        {
            int a = counting(count);           
            score = score + a;
            Score.Text = $"Очки: {score}";
        }
        private void UpdateMyNumber()//Обновляет текст с моим числом
        {
            if (UserNumber == default)
            {
                MyNumber.Text = " ";
            }
        }
        private void Updategame()
        {
            Title.Text = "Нажмите 'Новая игра'";
            Title.Location = new System.Drawing.Point(145, 25);
            Hint.Text = "Начните новую игру!";
            Hint.Location = new System.Drawing.Point(135, 120);
            ImputNumber.Text = "";
            UserNumber = default;
            ComputerNumber = default;
            count = default;
            score = 0;
        }
        private void CheckOver()//Проверяет сколько попыток осталось
        {
            if(count == 0)//Если попыток осталось 0 - то ира оконченна, все сначала
            {
                Hint.Location = new System.Drawing.Point(155, 120);
                Hint.Text = "Вы проиграли!";
                MessageBox.Show($"Набранно очков - {score}", "Вы проиграли!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                score = 0;
                Score.Text = $"Очки: {score}";
                Updategame();
            }
        }
        private void ContinueGame()//Обновляет игру когда угадали число и продолжает ее
        {
            random = new Random();
            ComputerNumber = random.Next(1, 100);
            Hint.Location = new System.Drawing.Point(140, 120);
            Hint.Text = "Введите ваше число!";
            Title.Text = "Число загаданно!";
            MyNumber.Text = " ";
            ImputNumber.Text = "";
            Title.Location = new System.Drawing.Point(160, 25);
            Count();
            UserNumber = default;
        }
        private void buttonStart_Click(object sender, EventArgs e)//Когда нажимаем новую игру
        {
            score = 0;
            Score.Text = $"Очки: {score}";
            ImputNumber.Text = "";
            ContinueGame();
        }
        private void Count(int a)//Обновляет попытки после каждого хода
        {
            count = count - a;
            MyCount.Text = $"Попытки: {count}";
        }
        private void Count()//Обновляет попытки по умолчанию 
        {
            count = 10;
            MyCount.Text = $"Попытки: {count}";
        }

        private void NumberOne_Click(object sender, EventArgs e)
        {
            if (ComputerNumber == default)//Если не начата игра, текст с моим введенным числом меняться не будет, так и со всеми кнопками!
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
            else
            {
                UserNumber = UserNumber + "1";
                MyNumber.Text = UserNumber;
            }
        }

        private void NumberTwo_Click(object sender, EventArgs e)
        {
            if (ComputerNumber == default)
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
            else 
            {
                UserNumber = UserNumber + "2";
                MyNumber.Text = UserNumber;
            }
        }

        private void NumberThree_Click(object sender, EventArgs e)
        {
            if (ComputerNumber == default)
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
            else
            {
                UserNumber = UserNumber + "3";
                MyNumber.Text = UserNumber;
            }
        }

        private void NumberFour_Click(object sender, EventArgs e)
        {
            if (ComputerNumber == default)
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
            else
            {
                UserNumber = UserNumber + "4";
                MyNumber.Text = UserNumber;
            }
        }

        private void NumberFive_Click(object sender, EventArgs e)
        {
            if (ComputerNumber == default)
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
            else
            {
                UserNumber = UserNumber + "5";
                MyNumber.Text = UserNumber;
            }
        }

        private void NumberSix_Click(object sender, EventArgs e)
        {
            if (ComputerNumber == default)
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
            else
            {
                UserNumber = UserNumber + "6";
                MyNumber.Text = UserNumber;
            }
        }

        private void NumberSeven_Click(object sender, EventArgs e)
        {
            if (ComputerNumber == default)
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
            else
            {
                UserNumber = UserNumber + "7";
                MyNumber.Text = UserNumber;
            }
        }

        private void NumberEight_Click(object sender, EventArgs e)
        {
            if (ComputerNumber == default)
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
            else
            {
                UserNumber = UserNumber + "8";
                MyNumber.Text = UserNumber;
            }
        }

        private void NumberNine_Click(object sender, EventArgs e)
        {
            if (ComputerNumber == default)
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
            else
            {
                UserNumber = UserNumber + "9";
                MyNumber.Text = UserNumber;
            }
        }

        private void NumberZero_Click(object sender, EventArgs e)
        {
            if (ComputerNumber == default)
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
            else
            {
                UserNumber = UserNumber + "0";
                MyNumber.Text = UserNumber;
            }
        }

        private void confirmationV2_Click(object sender, EventArgs e)//Кнопка ОК, которая привязанна к ручному вводу
        {
            if (ComputerNumber != default)//Если игра начата и набранно наше число, то кнопка 'ОК' сработает
            {
                if (ImputNumber.Text == "" && ComputerNumber != default)
                {
                    MessageBox.Show("Сначала введите число!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (ImputNumber.Text != "")//Если TextBox не пустой то метод выполнится 
                {
                    string b = ImputNumber.Text.ToString();//Тут хранится текст введенный в текстбокс
                    UserNumber = b;
                    int a;
                    bool result = int.TryParse(b, out a);//Пробуем конфертировать текст в число  
                    if (result == false)//Если мы приняли вместо числа буквы, то значение username будет равно 0
                    {
                        MessageBox.Show("Вводите только целые числа!", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        a = 0;                       
                        if (a < ComputerNumber)//Если наше число меньше загаданного
                        {
                            Hint.Location = new System.Drawing.Point(100, 120);
                            Hint.Text = "Введите ваше число!";
                            UserNumber = default;
                            UpdateMyNumber();//Не особо значимый метод, просто сделал обновление текста моего числа по умолчанию
                            ImputNumber.Text = "";
                        }
                    }
                    else
                    {
                        if (a < ComputerNumber)//Если наше число меньше загаданного
                        {
                            Hint.Location = new System.Drawing.Point(100, 120);
                            Hint.Text = $"Число {a} меньше загаданного!";
                            Count(1);//Отнимется одна попытка с помощью вызова этого метода
                            CheckOver();//Вызовется метод который проверит, а не проиграли ли мы
                            UserNumber = default;
                            UpdateMyNumber();//Не особо значимый метод, просто сделал обновление текста моего числа по умолчанию
                            ImputNumber.Text = "";
                        }
                        else if (a > ComputerNumber)//Если наше число больше загаданного
                        {
                            Hint.Location = new System.Drawing.Point(100, 120);
                            Hint.Text = $"Число {a} больше загаданного!";
                            Count(1);
                            CheckOver();
                            UserNumber = default;
                            UpdateMyNumber();
                            ImputNumber.Text = "";
                        }
                        else if (a == ComputerNumber)//Если мы угадали число то:
                        {
                            Hint.Location = new System.Drawing.Point(140, 120);
                            Hint.Text = "Вы угадали число!";
                            MessageBox.Show($"Полученно очков - {counting(count)}", "Вы угадали!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TableScore(count);//Посчитаются заработанные очки
                            ContinueGame();//И игра продолжится (т.е. начнется заново), с набранными очкими.
                        }
                    }
                }
            }
            else if (ComputerNumber == default)//Если грубо говоря игра не начата (число компьютера не сгенерированно), то кнопка 'ОК' не сработает
            {
                Hint.Location = new System.Drawing.Point(135, 120);
                Hint.Text = "Начните новую игру!";
            }
        }

        private void FinishGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Набранно очков - {score}", "Игра завершена!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
