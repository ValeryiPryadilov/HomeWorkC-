using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp6GameTrueFalse
{
    /// <summary>
    /// Все режимы игры
    /// </summary>
    public enum GameMode : byte
    {
        Hello,
        Quest,
        End
    }
    public class GameManager
    {
        /// <summary>
        /// Три вопроса игроку
        /// </summary>
        private const int SIZE_QUESTION = 3; 
        /// <summary>
        /// Текущий режим игры
        /// </summary>
        private GameMode mode; 
        /// <summary>
        /// Файл с вопросами
        /// </summary>
        private string fileName; 
        /// <summary>
        /// Все утверждения
        /// </summary>
        private List<Question> allQuestions;
        /// <summary>
        /// Сгенерированные утверждения для этой игры
        /// </summary>
        private int[] generedQuestions;
        /// <summary>
        /// Текущий вопрос в списке этом сгенерированном списке вопросов
        /// </summary>
        private int currentQuestion;
        /// <summary>
        /// Количество правильных ответов
        /// </summary>
        private int countAnsTrue;
        /// <summary>
        /// Текущее на очереди утверждение в игре
        /// </summary>
        public Question CurrQuestion => allQuestions[generedQuestions[currentQuestion]];

        public GameManager(string fileName = @"..\..\gamedata.dat", List<Question> baselist = null)
        {
            this.fileName = fileName;
            allQuestions = baselist ?? Load();
            mode = GameMode.Hello;
        }
        private List<Question> Load()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>));
            List<Question> list = new List<Question>();
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                list = (List<Question>)xmlSerializer.Deserialize(stream);
            }
            return list;
        }
        /// <summary>
        /// Команда начало игры
        /// </summary>
        public void GoGame()
        {
            mode = GameMode.Quest;
            Random rnd = new Random();
            generedQuestions = new int[SIZE_QUESTION];
            List<int> randNumbers = new List<int>();
            for (int i = 0; i < allQuestions.Count; i++)
            {
                randNumbers.Add(i);
            }
            for (int i = 0; i < SIZE_QUESTION; i++)
            {
                int r = rnd.Next(0, randNumbers.Count - 1);
                generedQuestions[i] = randNumbers[r];
                randNumbers.RemoveAt(r);
            }
            currentQuestion = 0;
            countAnsTrue = 0;
        }
        /// <summary>
        /// Ответ на утверждение от пользователя
        /// </summary>
        /// <param name="answerTrue"></param>
        public void Answer(bool answerTrue)
        {
            if (answerTrue == CurrQuestion.TrueFalse)
                countAnsTrue++;
            currentQuestion++;
            if (currentQuestion > SIZE_QUESTION - 1)
                mode = GameMode.End;
        }
        /// <summary>
        /// Установка значений на форму
        /// </summary>
        /// <param name="labelText"></param>
        /// <param name="btnGo"></param>
        /// <param name="btnTrue"></param>
        /// <param name="btnFalse"></param>
        public void SetForm(Label labelText, Button btnGo, Button btnTrue, Button btnFalse)
        {
            labelText.Text = mode switch
            {
                GameMode.Hello => "Добро пожаловать в игру!\nНажмите пожалуйства кнопку для начала игры!",
                GameMode.Quest => CurrQuestion.Text,
                GameMode.End when (countAnsTrue == SIZE_QUESTION)
                => "Поздравления!\nВы выиграли игру!\nНажмите на кнопку для повторной игры.",
                GameMode.End =>
                $"Вы проиграли игру!\nВы правильно ответили только на {countAnsTrue} вопроса из {SIZE_QUESTION}",
                _ => throw new ApplicationException("Индекс вне диапазона")
            };
            labelText.BackColor = mode switch
            {
                GameMode.Hello => Color.GreenYellow,
                GameMode.End when (countAnsTrue == SIZE_QUESTION)
                => Color.HotPink,
                GameMode.End => Color.IndianRed,
                _ => SystemColors.Control
            };
            btnGo.Visible = mode switch
            {
                GameMode.Hello => true,
                GameMode.End => true,
                GameMode.Quest => false
            };
            btnTrue.Visible = btnFalse.Visible = !btnGo.Visible;
        }
    }
    [Serializable]
    public struct Question
    {
        public string Text { get; set; }
        public bool TrueFalse { get; set; }
    }
}
