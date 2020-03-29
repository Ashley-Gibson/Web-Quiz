using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebQuiz.Models
{
    // View Model Class for storing data contained in the Single-Page Application
    public class QuizViewModel
    {
        // Username of the User
        public string userName { get; set; }

        // Stores the number of the question the User is currently answering
        public int questionNumber { get; set; }

        // Stores the content of each question
        public string questionText { get; set; }
        public readonly string[] questionTextArray = {
            "What is MVC short for?",
            "What type of class stores the data which is provided to the View?",
            "Functions created in a Controller are called what?",
            "asp-route is a tag helper which allows a developer to specify what?"
        };

        // Stores the Multiple Choice answers for each question
        public string[] answers { get; set; } = { "", "", "", ""};
        public readonly string[,] fullAnswersSet = { 
            { "Model, View, Controller", "Machine, Variable, Content", "Memory, Voxel, Constant", "Monitor, Variable, Computer" }, 
            {"Interface", "Superclass" , "Model", "Baseclass"},
            { "Action Methods", "Function Directives", "Method Callers", "Class Actions"},
            { "The Application homepage", "Action Method destination path", ".NET CORE package path", "Action Method parameter values"}
        };

        // Stores the score of the player
        public int score { get; set; }

        // Gets the total number of questions in the quiz
        public int totalQuestions { get; set; }
    }
}
