using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebQuiz.Models;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace WebQuiz.Controllers
{
    public class HomeController : Controller
    {
        // For reading Database
        private readonly QuestionDataContext _questionData;

        // HomeController Constructor
        public HomeController(QuestionDataContext questionData)
        {
            _questionData = questionData;
        }

        // Load Homepage
        public IActionResult Index(QuizViewModel qvm)
        {
            qvm.questionNumber = 0;
            return View();
        }

        // Error Handling
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult LoadNextQuestion([Bind("questionNumber,questionText,answers")] QuizViewModel qvm, string userName, int score = 0, int questionNumber = 0)
        {
            // Increment Question Number
            questionNumber++;

            // Get Database data
            DbSet<QuestionDataModel> questionData = _questionData.QuestionData;

            // Set total score
            qvm.totalQuestions = questionData.Count();

            // Check all Questions have not been answered
            string quizComplete = QuizEnd(questionData, questionNumber, score);

            // Check QuizEnd return and end quiz if all questions have been answered
            if (quizComplete == "LoadNextQuestion")
            {
                // Update Username
                qvm.userName = userName;
                TempData["UserName"] = userName;

                // Update score to the View
                TempData["score"] = score;
                qvm.score = score;

                // Update Question
                qvm.questionText = questionData.ToList()[questionNumber - 1].Question;

                // Update Answers
                qvm.answers[0] = questionData.ToList()[questionNumber - 1].Correct_Answer;
                qvm.answers[1] = questionData.ToList()[questionNumber - 1].Incorrect_Answer1;
                qvm.answers[2] = questionData.ToList()[questionNumber - 1].Incorrect_Answer2;
                qvm.answers[3] = questionData.ToList()[questionNumber - 1].Incorrect_Answer3;

                // Update Question Number
                qvm.questionNumber = questionNumber;

                // Return total number of questions in the quiz
                qvm.totalQuestions = _questionData.QuestionData.Count();
            }

            return View(quizComplete, qvm);
        }

        public string QuizEnd(DbSet<QuestionDataModel> questionData, int questionNumber, int score)
        {
            // If Question Number exceeds total questions in Database then show Quiz End Screen
            if(questionNumber > questionData.ToList().Count)
            {
                return "QuizEnd";
            }
            else
            {
                return "LoadNextQuestion";
            }
        }

        // Update the User's score after answering a question
        public void UpdateScore(string name, int score)
        {
            bool questionCorrect = false;

            // Increment score if the User got the answer correct
            if (questionCorrect)
            {
                score++;
            }

            // Update score to the View
            TempData["score"] = score;
        }
    }
}