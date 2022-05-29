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
        Random rnd = new Random();

        public int questionNumber = 0;
        public List<QATable> questionList;
        public Game()
        {
            MillionareQuestionsEntities1 db = new MillionareQuestionsEntities1();
            questionList = db.QATable.ToList();
            Initialize();
        }
        
        public void Initialize()
        {
            
        }
        
        public bool CheckClickedAnswer(string answerClicked,int questionNumber)
        {
            if (answerClicked == questionList[questionNumber].CorrectAnswer.ToString()) return true;
            else return false;         
        }

        public List<QATable> ReturnQuestionList()
        {
            return questionList;
        }

        public int CountPrize(int questionNumber)
        {
            int countedPrize;
            if(questionNumber>1 && questionNumber<7)
            {
                countedPrize = 1000;
            }
            else if(questionNumber>=7 && questionNumber<12)
            {
                countedPrize = 40000;
            }
            else if(questionNumber==12)
            {
                countedPrize = 1000000;
            }
            else
            {
                countedPrize = 0;
            }
            return countedPrize;
        }

        public List<string> ReturnTwoWrongAnswers(int questionNumber)
        {
            List<string> listOfTwoWrongAnswers = new List<string>();
            var randomInt = rnd.Next(0, 2);
            if (questionList[questionNumber].AnswerA != questionList[questionNumber].CorrectAnswer)
                listOfTwoWrongAnswers.Add(questionList[questionNumber].AnswerA);
            
            if (questionList[questionNumber].AnswerB != questionList[questionNumber].CorrectAnswer)
                listOfTwoWrongAnswers.Add(questionList[questionNumber].AnswerB);
            
            if (questionList[questionNumber].AnswerC != questionList[questionNumber].CorrectAnswer)
                listOfTwoWrongAnswers.Add(questionList[questionNumber].AnswerC);
            
            if (questionList[questionNumber].AnswerD != questionList[questionNumber].CorrectAnswer)
                listOfTwoWrongAnswers.Add(questionList[questionNumber].AnswerD);

            listOfTwoWrongAnswers.RemoveAt(randomInt);
            return listOfTwoWrongAnswers;

        }
        
    }
}
