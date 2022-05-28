using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektTest
{
    
    public class Game
    {
        public int questionNumber = 0;
        public Game()
        {
            Initialize();
        }
        List<QuestionModel> questionList = new List<QuestionModel>();

        QuestionModel q1 = new QuestionModel();
        QuestionModel q2 = new QuestionModel();
        QuestionModel q3 = new QuestionModel();
        QuestionModel q4 = new QuestionModel();

        public void Initialize()
        {
            q1.Question = "co pije krowa?";
            q1.AnswerA = "sok";
            q1.AnswerB = "piwo";
            q1.AnswerC = "wode";
            q1.AnswerD = "mleko";
            q1.CorrectAnswer = "piwo";

            q2.Id = 1;
            q2.Question = "jaki kolor ma snieg?";
            q2.AnswerA = "czerwony";
            q2.AnswerB = "bialy";
            q2.AnswerC = "czrny";
            q2.AnswerD = "zolty";
            q2.CorrectAnswer = "bialy";

            q3.Question = "najlepsze piwo to?";
            q3.AnswerA = "perla";
            q3.AnswerB = "harnas";
            q3.AnswerC = "tatra";
            q3.AnswerD = "lomza";
            q3.CorrectAnswer = "lomza";

            q4.Id = 1;
            q4.Question = "kiedy jest zima?";
            q4.AnswerA = "w zmie";
            q4.AnswerB = "w lato";
            q4.AnswerC = "w jesien";
            q4.AnswerD = "w wiosne";
            q4.CorrectAnswer = "w zime";

            questionList.Add(q1);
            questionList.Add(q2);
            questionList.Add(q3);
            questionList.Add(q4);
        }
        
        public bool CheckClickedAnswer(string answerClicked,int questionNumber)
        {
            if (answerClicked == questionList[questionNumber].CorrectAnswer.ToString()) return true;
            else return false;         
        }

        public List<QuestionModel> ReturnQuestionList()
        {
            return questionList;
        }


    }
}
