using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Examino.Models.Entities
{
    public class UserQuiz
    {
        [Key]
        public int Id { get; set; }



        public int NoteFinale { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser User { get; set; }


        public int QuizFinalId { get; set; }

        [ForeignKey("QuizFinalId")]
        public virtual QuizModel QuizPassed { get; set; }


        public virtual ICollection<UserAnswer> UserAnswers { get; set; }

    }
}