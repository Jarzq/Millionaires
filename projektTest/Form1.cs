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
        public int questionNumber;
        public List<QATable> questionList;
        List<Label> prizesList = new List<Label>();


        public FormMain()
        {
            InitializeComponent();
            questionList = game.ReturnQuestionList();
            questionNumber = game.questionNumber;
           
            DisplayQuestions(questionList, questionNumber);
            var urbanski = Image.FromFile(@"img\Urbanski.jpg");

            prizesList.Add(label1prize); prizesList.Add(label2prize); prizesList.Add(label3prize); prizesList.Add(label4prize); prizesList.Add(label5prize); prizesList.Add(label6prize);
            prizesList.Add(label7prize); prizesList.Add(label8prize); prizesList.Add(label9prize); prizesList.Add(label10prize); prizesList.Add(label11prize); prizesList.Add(label12prize);
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            labelTimeOver.Hide();
            labelFriendCall.Hide();
            clock.EndOfTime += OnEndOfTime;
        }
        public void OnEndOfTime()
        {
            clock.EndOfTime -= OnEndOfTime;
            timer1.Stop();
            labelTimeOver.Show();
            
            Refresh();
            System.Threading.Thread.Sleep(1200);
            lose();
           
        }
        public void DisplayQuestions(List<QATable> questionList, int questionNumber)
        {
            labelQuestion.Text = questionList[questionNumber].Question;
            buttonAnswerA.Text = questionList[questionNumber].AnswerA; buttonAnswerA.Enabled = true;
            buttonAnswerB.Text = questionList[questionNumber].AnswerB; buttonAnswerB.Enabled = true;
            buttonAnswerC.Text = questionList[questionNumber].AnswerC; buttonAnswerC.Enabled = true;
            buttonAnswerD.Text = questionList[questionNumber].AnswerD; buttonAnswerD.Enabled = true;

            panelClock.Show();
            tick = 0;
            labelFriendCall.Hide();

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            if ((questionNumber - 1) >= 0) {
                prizesList[questionNumber - 1].BackColor = Color.DodgerBlue;
            }
            if(questionNumber<12)
                prizesList[questionNumber].BackColor = Color.Orange;

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

        private void buttonAnswerA_Click(object sender, EventArgs e)
        {
            buttonAnyAnswerClick(buttonAnswerA);
        }
        private void buttonAnswerB_Click(object sender, EventArgs e)
        {
            buttonAnyAnswerClick(buttonAnswerB);
        }
        private void buttonAnswerC_Click(object sender, EventArgs e)
        {
            buttonAnyAnswerClick(buttonAnswerC);
        }
        private void buttonAnswerD_Click(object sender, EventArgs e)
        {
            buttonAnyAnswerClick(buttonAnswerD);
        }
        private void buttonAnyAnswerClick(Button button)
        {
            

            button.BackColor = Color.Orange;
            Refresh();
            System.Threading.Thread.Sleep(1000);

            if (game.CheckClickedAnswer(button.Text, questionNumber) == true)
            {
                
                questionNumber++;
                button.BackColor = Color.Green;
                Refresh();
                if (questionNumber == 12)
                {
                    lose();
                }
                System.Threading.Thread.Sleep(1000);
                button.BackColor = Color.Black;
                DisplayQuestions(questionList, questionNumber);                
            }
            else
            {             
                button.BackColor = Color.Red;
                Refresh();
                
                lose();             
            }
        }

        private void lose()
        {
            System.Threading.Thread.Sleep(1000);
            int countedPrize = game.CountPrize(questionNumber);
            this.Hide();
            FormGameOver formGameOver = new FormGameOver(countedPrize);
            formGameOver.Closed += (s, args) => this.Close();
            formGameOver.Show();
        }

        private void button5050_Click(object sender, EventArgs e)
        {
            List<string> twoWrongAnswers = new List<string>();

            twoWrongAnswers = game.ReturnTwoWrongAnswers(questionNumber);

            if(buttonAnswerA.Text == twoWrongAnswers[0] || buttonAnswerA.Text == twoWrongAnswers[1])
                buttonAnswerA.Enabled = false;
            if (buttonAnswerB.Text == twoWrongAnswers[0] || buttonAnswerB.Text == twoWrongAnswers[1])
                buttonAnswerB.Enabled = false;
            if (buttonAnswerC.Text == twoWrongAnswers[0] || buttonAnswerC.Text == twoWrongAnswers[1])
                buttonAnswerC.Enabled = false;
            if (buttonAnswerD.Text == twoWrongAnswers[0] || buttonAnswerD.Text == twoWrongAnswers[1])
                buttonAnswerD.Enabled = false;


            DisableHelpButton(button5050);


        }

        private void buttonFriendCall_Click(object sender, EventArgs e)
        {

            string friendAnswer;
            if ((int)tick % 2 == 0)
                friendAnswer = questionList[questionNumber].AnswerB;
            else
                friendAnswer = questionList[questionNumber].CorrectAnswer;

            labelFriendCall.Text = $"Cześć, wydaje mi się, że odpowiedź '{friendAnswer}' jest poprawna";
            labelFriendCall.Show();

            DisableHelpButton(buttonFriendCall);

        }
        private void buttonSkip_Click(object sender, EventArgs e)
        {
            questionNumber++;
            DisplayQuestions(questionList, questionNumber);
            if (questionNumber == 12)
            {
                lose();
            }

            DisableHelpButton(buttonSkip);
        }

        private void DisableHelpButton(Button button)
        {
            button.Enabled = false;
            button.BackgroundImage = Image.FromFile(@"C:\Users\Tomasz\Desktop\projektTest\projektTest\img\red.png");
        }

        private void labelQuestion_MouseHover(object sender, EventArgs e)
        {
            button5050.BackColor = Color.BlanchedAlmond;
        }
    }
}
