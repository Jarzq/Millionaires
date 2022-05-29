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
        public void startGame()
        {
            panelQuestionAnswer.Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelTimeOver.Hide();
        }

        public void DisplayQuestions(List<QATable> questionList, int questionNumber)
        {
            labelQuestion.Text = questionList[questionNumber].Question;
            buttonAnswerA.Text = questionList[questionNumber].AnswerA;
            buttonAnswerB.Text = questionList[questionNumber].AnswerB;
            buttonAnswerC.Text = questionList[questionNumber].AnswerC;
            buttonAnswerD.Text = questionList[questionNumber].AnswerD;
            //buttonAnswerD.Text = questionNumber.ToString();

            panel1.Show();
            tick = 0;

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
            if (tick / 6 > 60)
            {
                timer1.Stop();
                labelTimeOver.Show();
                Refresh();
                System.Threading.Thread.Sleep(2000);
                lose();

            }
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

        
        
    }
}
