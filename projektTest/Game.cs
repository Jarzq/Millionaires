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

        
        public void Initialize()
        {
            q1.Question = "co pije krowa?";
            q1.AnswerA = "sok";
            q1.AnswerB = "piwo";
            q1.AnswerC = "wode";
            q1.AnswerD = "mleko";
            q1.CorrectAnswer = "wode";

            q2.Id = 1;
            q2.Question = "co pije krowa?";
            q2.AnswerA = "sok";
            q2.AnswerB = "piwo";
            q2.AnswerC = "wode";
            q2.AnswerD = "mleko";
            q2.CorrectAnswer = "wode";

            questionList.Add(q1);
            questionList.Add(q2);
        }

        internal object ReturnQuestionNumber()
        {
            throw new NotImplementedException();
        }

        public void CheckClickedAnswer(string answerClicked)
        {

        }

        public List<QuestionModel> ReturnQuestionList()
        {
            return questionList;
        }


    }
}
