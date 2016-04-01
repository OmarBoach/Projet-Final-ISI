using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examino.Models.Entities
{
    public class QuizModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsRandom { get; set; }

        public int duration { get; set; }

        public QuizModelType TypeQuiz { get; set; }

        public virtual ICollection<QuestionModel> QuestionsModels { get; set; }

    }


    public enum QuizModelType
    {
        Formatif, Final
    }
}