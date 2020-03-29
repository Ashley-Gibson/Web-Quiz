using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebQuiz.Models
{
    public partial class QuestionDataModel
    {
        public int Id { get; set; }

        public string Question { get; set; }
        public string Correct_Answer { get; set; }
        public string Incorrect_Answer1 { get; set; }
        public string Incorrect_Answer2 { get; set; }
        public string Incorrect_Answer3 { get; set; }
    }
}
