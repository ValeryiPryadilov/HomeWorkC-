using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp6GameTrueFalse;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6GameTrueFalse.Tests
{
    [TestClass()]
    public class GameManagerTests
    {
        [TestMethod()]
        public void InitTest()
        {
            List<Question> allQuestions = new List<Question>
            {
                new Question(){Text = "Test1", TrueFalse = true},
                new Question(){Text = "Test2", TrueFalse = true},
                new Question(){Text = "Test3", TrueFalse = true},
            };
            GameManager manager = new GameManager(baselist:allQuestions);
            Label labelText = new Label();
            Button btnGo = new Button();
            Button btnTrue = new Button();
            Button btnFalse = new Button();
            manager.SetForm(labelText, btnGo, btnTrue, btnFalse);
            Assert.AreEqual(true, btnGo.Visible);
            Assert.AreEqual(false, btnTrue.Visible);
            Assert.AreEqual(false, btnFalse.Visible);
            Assert.AreEqual("Добро пожаловать в игру!\nНажмите пожалуйства кнопку для начала игры!", labelText.Text);
            Assert.AreEqual(Color.GreenYellow, labelText.BackColor);
        }
        
        [TestMethod()]
        public void GoGameTest()
        {
            List<Question> allQuestions = new List<Question>
            {
                new Question(){Text = "Test1", TrueFalse = true},
                new Question(){Text = "Test2", TrueFalse = true},
                new Question(){Text = "Test3", TrueFalse = true},
            };
            GameManager manager = new GameManager(baselist:allQuestions);
            manager.GoGame();
            Label labelText = new Label();
            Button btnGo = new Button();
            Button btnTrue = new Button();
            Button btnFalse = new Button();
            manager.SetForm(labelText, btnGo, btnTrue, btnFalse);
            Assert.AreEqual(false, btnGo.Visible);
            Assert.AreEqual(true, btnTrue.Visible);
            Assert.AreEqual(true, btnFalse.Visible);
            Assert.IsTrue(labelText.Text == allQuestions[0].Text 
                          || labelText.Text == allQuestions[1].Text 
                          || labelText.Text == allQuestions[2].Text);
            Assert.AreEqual(SystemColors.Control, labelText.BackColor);
        }

        [TestMethod()]
        public void AnswerTest()
        {
            List<Question> allQuestions = new List<Question>
            {
                new Question(){Text = "Test1", TrueFalse = true},
                new Question(){Text = "Test2", TrueFalse = true},
                new Question(){Text = "Test3", TrueFalse = true},
            };
            GameManager manager = new GameManager(baselist:allQuestions);
            manager.GoGame();
            manager.Answer(true);
            Label labelText = new Label();
            Button btnGo = new Button();
            Button btnTrue = new Button();
            Button btnFalse = new Button();
            manager.SetForm(labelText, btnGo, btnTrue, btnFalse);
            Assert.AreEqual(false, btnGo.Visible);
            Assert.AreEqual(true, btnTrue.Visible);
            Assert.AreEqual(true, btnFalse.Visible);
            Assert.IsTrue(labelText.Text == allQuestions[0].Text 
                          || labelText.Text == allQuestions[1].Text 
                          || labelText.Text == allQuestions[2].Text);
            Assert.AreEqual(SystemColors.Control, labelText.BackColor);
        }

        [TestMethod()]
        public void WinTest()
        {
            List<Question> allQuestions = new List<Question>
            {
                new Question(){Text = "Test1", TrueFalse = true},
                new Question(){Text = "Test2", TrueFalse = true},
                new Question(){Text = "Test3", TrueFalse = true},
            };
            GameManager manager = new GameManager(baselist:allQuestions);
            manager.GoGame();
            manager.Answer(true);
            manager.Answer(true);
            manager.Answer(true);
            Label labelText = new Label();
            Button btnGo = new Button();
            Button btnTrue = new Button();
            Button btnFalse = new Button();
            manager.SetForm(labelText, btnGo, btnTrue, btnFalse);
            Assert.AreEqual(true, btnGo.Visible);
            Assert.AreEqual(false, btnTrue.Visible);
            Assert.AreEqual(false, btnFalse.Visible);
            Assert.AreEqual("Поздравления!\nВы выиграли игру!\nНажмите на кнопку для повторной игры.", labelText.Text);
            Assert.AreEqual(Color.HotPink, labelText.BackColor);
        }

        [TestMethod()]
        public void DefeatTest()
        {
            List<Question> allQuestions = new List<Question>
            {
                new Question(){Text = "Test1", TrueFalse = true},
                new Question(){Text = "Test2", TrueFalse = true},
                new Question(){Text = "Test3", TrueFalse = true},
            };
            GameManager manager = new GameManager(baselist:allQuestions);
            manager.GoGame();
            manager.Answer(false);
            manager.Answer(true);
            manager.Answer(true);
            Label labelText = new Label();
            Button btnGo = new Button();
            Button btnTrue = new Button();
            Button btnFalse = new Button();
            manager.SetForm(labelText, btnGo, btnTrue, btnFalse);
            Assert.AreEqual(true, btnGo.Visible);
            Assert.AreEqual(false, btnTrue.Visible);
            Assert.AreEqual(false, btnFalse.Visible);
            Assert.AreEqual("Вы проиграли игру!\nВы правильно ответили только на 2 вопроса из 3", labelText.Text);
            Assert.AreEqual(Color.IndianRed, labelText.BackColor);
        }
    }
}