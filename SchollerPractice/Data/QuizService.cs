using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchollerPractice.Data
{
    public class QuizService
    {
        private static readonly List<QuizItem> Quiz;

        static QuizService()
        {
            Quiz = new List<QuizItem> {
                new QuizItem
                {
                    Question = "Mi a magyar neve a Schielhau ütésnek?",
                    Choices = new List<string> {"Düh-ütés", "Skalp-ütés", "Alsó-ütés", "Kereszt-ütés"},
                    AnswerIndex = 1,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Hogy hívják németül a \"Sanda\" ütést?",
                    Choices = new List<string> {"Schielhau", "Zornhau", "Scheitelhau", "Zwerchau"},
                    AnswerIndex = 2,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a \"Pflug\" alapállás magyarul?",
                    Choices = new List<string> {"Eke", "Ökör", "Bolond", "Korona"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                /*new QuizItem
                {
                    Question = "Melyik a \"Pflug\" alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vontag.png", "alber.png"},
                    AnswerIndex = 1,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Scheitelhau"},
                    AnswerIndex = 2,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "zornhau.gif"
                }*/
            };
        }

        public Task<List<QuizItem>> GetQuizAsync()
        {
            return Task.FromResult(Quiz);
        }

    }
}
