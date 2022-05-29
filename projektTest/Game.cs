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
            else if(questionNumber>=7 && questionNumber<13)
            {
                countedPrize = 40000;
            }
            else if(questionNumber==13)
            {
                countedPrize = 1000000;
            }
            else
            {
                countedPrize = 0;
            }
            return countedPrize;
        }
    }
}
