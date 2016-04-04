using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Examino.Models.Entities
{
    public class UserAnswer
    {
        [Key]
        public int Id { get; set; }

      
        public int UserQuizId { get; set; }

        
        public int AnswerModelId { get; set; }

        
  
        public virtual UserQuiz UserQuiz { get; set; }

     
        public virtual AnswerModel AnswerModel { get; set; }

        public string LabelAnswer { get; set; }

        public bool Answer { get; set; }

        public int NoteAnswer { get; set; }

    }
}
