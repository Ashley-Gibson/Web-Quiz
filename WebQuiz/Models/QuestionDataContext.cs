using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebQuiz.Models;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebQuiz.Models
{
    public class QuestionDataContext : DbContext 
    {        
        public virtual DbSet<QuestionDataModel> QuestionData     { get; set; }

        public QuestionDataContext(DbContextOptions<QuestionDataContext> options) : base(options)
        {

        }
    }
}
