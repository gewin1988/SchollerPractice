using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchollerPractice.Data
{
    public enum QuestionOrAnswerType
    {
        Text,
        Link,
        Image,
        Gif,
        Video
    }
    
       
        public class QuizItem
        {
            public string Question { get; set; }
            public List<string> Choices { get; set; }
            public int AnswerIndex { get; set; }
            public string Answer { get; set; } = "";
        public int Score { get; set; } = 1;
            public string ResultClass { get; set; } = "my-header-h3";
            public QuestionOrAnswerType QuestionAnswerType { get; set; }
            public QuestionOrAnswerType QuestionQuestionType { get; set; }
            public string QuestionImage { get; set; }
            public QuizItem()
                {
                    Choices = new List<string>();
                }
            }

    
}
