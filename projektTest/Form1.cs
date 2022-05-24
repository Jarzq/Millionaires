using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektTest
{
    public partial class FormMain : Form
    {
        Game game = new Game();

        Clock clock = new Clock();
        public float  tick=0;
  
        public FormMain()
        {
            InitializeComponent();

            var questionList = game.ReturnQuestionList();
            int questionNumber = game.questionNumber;
            DisplayQuestions(questionList, questionNumber);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void DisplayQuestions(List<QuestionModel> questionList, int questionNumber)
        {
            labelQuestion.Text = questionList[questionNumber].Question;
            buttonAnswerA.Text = questionList[questionNumber].AnswerA;
            buttonAnswerB.Text = questionList[questionNumber].AnswerB;
            buttonAnswerC.Text = questionList[questionNumber].AnswerC;
            buttonAnswerD.Text = questionList[questionNumber].AnswerD;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick+=0.4f;
            Refresh();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            clock.Draw(e.Graphics, tick, labelClock);
        }

        private void buttonAnswerB_Click(object sender, EventArgs e)
        {
            game.CheckClickedAnswer(buttonAnswerB.Text);
        }
    }
}
