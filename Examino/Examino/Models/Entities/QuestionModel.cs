using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Examino.Models.Entities
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string LabelQuestion { get; set; }

        public QuestionType Type { get; set; }

        public int Weight { get; set; }

        public string SolutionDescription { get; set; }

        public string PicturePath { get; set; }

        public int QuizModelId { get; set; }


  
        public virtual QuizModel QuizModel { get; set; }

        public virtual ICollection<AnswerModel> AnswersModels { get; set; }

    }

    public enum QuestionType
    {
        MultipleChoiceQuestion, FillIntheBlankQuestion, DeveloppementQuestion
    }
}