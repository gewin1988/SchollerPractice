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
                /*Ütések Német -> Magyar */
                new QuizItem
                {
                    Question = "Mi a magyar neve a \"Schielhau\" ütésnek?",
                    Choices = new List<string> {"Düh-ütés", "Skalp-ütés", "Alsó-ütés", "Kereszt-ütés", "Sanda-ütés", "Kampó-ütés"},
                    AnswerIndex = 4,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a magyar neve a \"Zwerchau\" ütésnek?",
                    Choices = new List<string> {"Düh-ütés", "Skalp-ütés", "Alsó-ütés", "Kereszt-ütés", "Sanda-ütés", "Kampó-ütés"},
                    AnswerIndex =3,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },new QuizItem
                {
                    Question = "Mi a magyar neve a \"Zornhau\" ütésnek?",
                    Choices = new List<string> {"Düh-ütés", "Skalp-ütés", "Alsó-ütés", "Kereszt-ütés", "Sanda-ütés", "Kampó-ütés"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a magyar neve a \"Scheitelhau\" ütésnek?",
                    Choices = new List<string> {"Düh-ütés", "Skalp-ütés", "Alsó-ütés", "Kereszt-ütés", "Sanda-ütés", "Kampó-ütés"},
                    AnswerIndex = 1,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a magyar neve a \"Unterhau\" ütésnek?",
                    Choices = new List<string> {"Düh-ütés", "Skalp-ütés", "Alsó-ütés", "Kereszt-ütés", "Sanda-ütés", "Kampó-ütés"},
                    AnswerIndex = 2,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a magyar neve a \"Krumphau\" ütésnek?",
                    Choices = new List<string> {"Düh-ütés", "Skalp-ütés", "Alsó-ütés", "Kereszt-ütés", "Sanda-ütés", "Kampó-ütés"},
                    AnswerIndex = 5,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                /*Ütések Német -> Magyar end */
                //---------------------------------------------------------------------------------------------
                /*Ütés Magyar -> Német */
                new QuizItem
                {
                    Question = "Hogy hívják németül a \"Düh\"-ütést?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Scheitelhau", "Krumphau", "Unterhau"},
                    AnswerIndex = 2,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                },
                new QuizItem
                {
                    Question = "Hogy hívják németül a \"Kereszt\"-ütést?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Scheitelhau", "Krumphau", "Unterhau"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                }
                ,
                new QuizItem
                {
                    Question = "Hogy hívják németül a \"Alsó\"-ütést?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Unterhau", "Krumphau", "Scheitelhau"},
                    AnswerIndex = 3,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                },
                new QuizItem
                {
                    Question = "Hogy hívják németül a \"Skalp\"-ütést?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Scheitelhau", "Krumphau", "Unterhau"},
                    AnswerIndex = 3,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                },
                new QuizItem
                {
                    Question = "Hogy hívják németül a \"Sanda\" ütést?",
                    Choices = new List<string> {"Schielhau", "Zornhau", "Scheitelhau", "Zwerchau", "Krumphau", "Unterhau"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Hogy hívják németül a \"Kampó\" ütést?",
                    Choices = new List<string> {"Krumphau", "Zornhau", "Scheitelhau", "Zwerchau", "Schielhau", "Unterhau"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                /*Ütés Magyar -> Német end*/
                //-------------------------------------------------------------------------------------------------------
                /*Alapállás Német -> Magyar*/
                new QuizItem
                {
                    Question = "Mi a \"Pflug\" alapállás magyarul?",
                    Choices = new List<string> {"Eke", "Ökör", "Bolond", "Korona", "Felső"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a \"Ochs\" alapállás magyarul?",
                    Choices = new List<string> {"Eke", "Ökör", "Bolond", "Korona", "Felső"},
                    AnswerIndex = 1,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a \"Alber\" alapállás magyarul?",
                    Choices = new List<string> {"Eke", "Ökör", "Bolond", "Korona", "Felső"},
                    AnswerIndex = 2,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a \"Kron\" alapállás magyarul?",
                    Choices = new List<string> {"Eke", "Ökör", "Bolond", "Korona", "Felső"},
                    AnswerIndex = 3,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },               
                new QuizItem
                {
                    Question = "Mi a \"Vom Tag (Vom Tach)\" alapállás magyarul?",
                    Choices = new List<string> {"Eke", "Ökör", "Bolond", "Korona", "Felső"},
                    AnswerIndex = 4,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                 /*Alapállás Német -> Magyar end*/
                 //----------------------------------------------------------------------------------------------
                 /*Alapállás Magyar -> Német */
                 new QuizItem
                {
                    Question = "Mi az Eke alapállás németül?",
                    Choices = new List<string> {"Pflug", "Ochs", "Aber", "Kron", "Vom tag"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi az Ökör alapállás németül?",
                    Choices = new List<string> {"Pflug", "Ochs", "Aber", "Kron", "Vom tag"},
                    AnswerIndex = 1,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a Bolond alapállás németül?",
                    Choices = new List<string> {"Pflug", "Ochs", "Aber", "Kron", "Vom tag"},
                    AnswerIndex = 2,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a Korona alapállás németül?",
                    Choices = new List<string> {"Pflug", "Ochs", "Aber", "Kron", "Vom tag"},
                    AnswerIndex = 3,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Mi a Felső alapállás németül?",
                    Choices = new List<string> {"Pflug", "Ochs", "Aber", "Kron", "Vom tag" },
                    AnswerIndex = 4,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                /*Alapállás Magyar -> Német end */
                //------------------------------------------------------------------------------------------------
                /*Alapállás képről Német */
                new QuizItem
                {
                    Question = "Melyik a \"Pflug\" alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vomtag.png", "alber.png", "kron.png"},
                    AnswerIndex = 1,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Melyik az \"Ochs\" alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vomtag.png", "alber.png", "kron.png"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },new QuizItem
                {
                    Question = "Melyik a \"Vonm tag\" alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vomtag.png", "alber.png", "kron.png"},
                    AnswerIndex = 2,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Melyik az \"Alber\" alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vomtag.png", "alber.png", "kron.png"},
                    AnswerIndex = 3,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Melyik a \"Kron\" alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vomtag.png", "alber.png", "kron.png"},
                    AnswerIndex = 4,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                /*Alapállás képről Német end*/
                //-------------------------------------------------------------------------------------------------
                /*Alapállás képről Magyar*/
                new QuizItem
                {
                    Question = "Melyik az Eke alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vomtag.png", "alber.png", "kron.png"},
                    AnswerIndex = 1,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Melyik az Ökör alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vomtag.png", "alber.png", "kron.png"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },new QuizItem
                {
                    Question = "Melyik a Felső alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vomtag.png", "alber.png", "kron.png"},
                    AnswerIndex = 2,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Melyik az Bolond alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vomtag.png", "alber.png", "kron.png"},
                    AnswerIndex = 3,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                new QuizItem
                {
                    Question = "Melyik az Korona alapállás?",
                    Choices = new List<string> {"ochs.png", "pflug.png", "vomtag.png", "alber.png", "kron.png"},
                    AnswerIndex = 4,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Image,
                    QuestionQuestionType = QuestionOrAnswerType.Text,
                    QuestionImage = ""
                },
                /*Alapállás képről Magyar end*/
                //-------------------------------------------------------------------------------------------------
                /*Ütés képről Német*/
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Scheitelhau", "Krumphau", "Unterhau"},
                    AnswerIndex = 2,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "zornhau.gif"
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Scheitelhau", "Krumphau", "Unterhau"},
                    AnswerIndex = 4,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "Krumphau.gif"
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Scheitelhau", "Krumphau", "Unterhau"},
                    AnswerIndex = 3,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "Scheitelhau.gif"
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Scheitelhau", "Krumphau", "Unterhau"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "Zwerchau.gif"
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Scheitelhau", "Krumphau", "Unterhau"},
                    AnswerIndex = 1,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "Schielhau.gif"
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Zwerchau", "Schielhau", "Zornhau", "Scheitelhau", "Krumphau", "Unterhau"},
                    AnswerIndex = 5,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "Unterhau.gif"
                },
                /*Ütés képről Német end*/
                //--------------------------------------------------------------------------------------------------
                /*Ütés képről Magyar */
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Kereszt", "Skalp", "Düh", "Sanda", "Kampó", "Alsó"},
                    AnswerIndex = 2,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "zornhau.gif"
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Kereszt", "Skalp", "Düh", "Sanda", "Kampó", "Alsó"},
                    AnswerIndex = 4,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "Krumphau.gif"
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Kereszt", "Skalp", "Düh", "Sanda", "Kampó", "Alsó"},
                    AnswerIndex = 1,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "Scheitelhau.gif"
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Kereszt", "Skalp", "Düh", "Sanda", "Kampó", "Alsó"},
                    AnswerIndex = 0,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "Zwerchau.gif"
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Kereszt", "Skalp", "Düh", "Sanda", "Kampó", "Alsó"},
                    AnswerIndex = 3,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "Schielhau.gif"
                },
                new QuizItem
                {
                    Question = "Milyen ütés látható a videón?",
                    Choices = new List<string> {"Kereszt", "Skalp", "Düh", "Sanda", "Kampó", "Alsó"},
                    AnswerIndex = 5,
                    Score = 1,
                    QuestionAnswerType = QuestionOrAnswerType.Text,
                    QuestionQuestionType = QuestionOrAnswerType.Image,
                    QuestionImage = "Unterhau.gif"
                }
                /*Ütés képről Magyar end*/
            };

           
        }

        public Task<List<QuizItem>> GetQuizAsync()
        {
            foreach (var item in Quiz)
            {
                Console.WriteLine("length = ", Quiz.Count);
                item.Answer = item.Choices.ElementAt(item.AnswerIndex);
                Console.WriteLine("answer = ", item.Answer);
                Console.WriteLine("elementat = ", item.Choices.ElementAt(item.AnswerIndex));
                Console.WriteLine("answerindex = ", item.AnswerIndex);
                //randomize after answer is set
                var rnd = new Random();
                var tmp = item.Choices;
                item.Choices = tmp.OrderBy(i => rnd.Next()).ToList();
            }
            return Task.FromResult(Quiz);
        }

    }
}
