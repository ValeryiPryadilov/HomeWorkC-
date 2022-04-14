using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkNo7
{
    public partial class Form2 : Form
    {
        int UserNumber = 0;
        int BufferUserNumber;
        int ComputerNumber;
        int Score;
        int Count;
        int Level = 1;
        public Form2()
        {
            InitializeComponent();           
        }
        
        private void StartGame_Click(object sender, EventArgs e)
        {
            StartGame.Visible = false;
            UserNumText.Visible = true;
            PlusNumber.Visible = true;
            MultiNumber.Visible = true;
            MyNumber.Visible = true;
            Rollback.Visible = true;
            LevelNumber.Visible = true;
            MyScore.Visible = true;
            MyCount.Visible = true;
            ByeRollbackInfo.Visible = true;
            ByePlusCount.Visible = true;
            PlusOneCount.Visible = true;
            Random random = new Random();
            ComputerNumber = random.Next(16,18);
            ComputerNumText.Text = $@"Получите число

            {ComputerNumber}";
            ComputerNumText.Location = new System.Drawing.Point(260, 46);
            Count = 6;
            Score = 0;
            MyCount.Text = $"Ходы: {Count}";
        }
        private void LeveChanged()
        {
            Level += 1;
            LevelNumber.Text = $"Уровень {Level}";
            int min = (Level + Level) * 10;
            int max = (Level + Level) * 12;
            Random random = new Random();
            ComputerNumber = random.Next(min, max);
            ComputerNumText.Text = $@"Получите число

            {ComputerNumber}";
            Count = 5;
            Count *= Level;
            MyCount.Text = $"Ходы: {Count}";
        }
        private void CheckCount()
        {
            Count -= 1;
            MyCount.Text = $"Ходы: {Count}";
        }
        private void CheckWinner()
        {
            if (UserNumber == ComputerNumber && ComputerNumber != default)
            {
                MessageBox.Show("Уровень пройден!", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Получено 15 очков!", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Score += 15;
                MyScore.Text = $"Очки: {Score}";
                LeveChanged();
                if (Level > 5)
                {
                    MessageBox.Show("Вы прошли игру!!", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                UserNumber = 0;
                BufferUserNumber = UserNumber;
                MyNumber.Text = "0";
                MyNumber.Location = new System.Drawing.Point(335, 234);
            }
            if(Count == 0 || UserNumber > ComputerNumber)
            {
                MessageBox.Show("Игра окончена!", "Вы проиграли!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Score = 0;
                MyScore.Text = $"Очки: {Score}";
                StartGame.Visible = true;
                UserNumText.Visible = false;
                PlusNumber.Visible = false;
                MultiNumber.Visible = false;
                MyNumber.Visible = false;
                Rollback.Visible = false;
                LevelNumber.Visible = false;
                MyScore.Visible = false;
                MyCount.Visible = false;
                ByeRollbackInfo.Visible = false;
                ByePlusCount.Visible = false;
                PlusOneCount.Visible = false;
                ComputerNumText.Text = "Нажмите Start";
                ComputerNumText.Location = new System.Drawing.Point(270, 46);
                MyNumber.Text = "0";
                MyNumber.Location = new System.Drawing.Point(335, 234);
                UserNumber = 0;
                BufferUserNumber = 0;
                Level = 1;
                LevelNumber.Text = $"Уровень {Level}";
            }
        }
        private void PlusNumber_Click(object sender, EventArgs e)
        {
            CheckCount();
            BufferUserNumber = UserNumber;
            UserNumber += 1;
            if(UserNumber >= 10)
            {
                MyNumber.Location = new System.Drawing.Point(330, 234);
            }
            if (UserNumber >= 100)
            {
                MyNumber.Location = new System.Drawing.Point(340, 234);
            }
            MyNumber.Text = $"{UserNumber}";
            CheckWinner();
        }

        private void MultiNumber_Click(object sender, EventArgs e)
        {
            CheckCount();
            BufferUserNumber = UserNumber;
            UserNumber *= 2;
            if (UserNumber >= 10)
            {
                MyNumber.Location = new System.Drawing.Point(330, 234);
            }
            if (UserNumber >= 100)
            {
                MyNumber.Location = new System.Drawing.Point(340, 234);
            }
            MyNumber.Text = $"{UserNumber}";
            CheckWinner();
        }

        private void Rollback_Click(object sender, EventArgs e)
        {
            if (Score >= 5)
            {
                Score -= 5;
                MyScore.Text = $"Очки: {Score}";
                MessageBox.Show("Ход отменен!", "Отмена хода", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserNumber = BufferUserNumber;
                MyNumber.Text = $"{UserNumber}";
            }
            else if (Score < 5)
            {
                MessageBox.Show("Недостаточно очков!", "Отмена хода", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PlusOneCount_Click(object sender, EventArgs e)
        {
            if(Score >= 15)
            {
                MessageBox.Show("Потрачео 15 очков", "Доп. ход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Count++;
                MyCount.Text = $"Ходы: {Count}";
                Score -= 15;
                MyScore.Text = $"Очки: {Score}";
            }
            else if(Score < 15)
            {
                MessageBox.Show("Недостаточно очков", "Доп. ход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
