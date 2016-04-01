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

        [Required]
        public int UserQuizId { get; set; }

        [Required]
        public int AnswerModelId { get; set; }

        
        [ForeignKey("UserQuizId")]
        public virtual UserQuiz UserQuiz { get; set; }

        [ForeignKey("AnswerModelId")]
        public virtual AnswerModel AnswerModel { get; set; }

        public string LabelAnswer { get; set; }

        public bool Answer { get; set; }

        public int NoteAnswer { get; set; }

    }
}
