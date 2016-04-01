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

        [Required]
        public string ApplicationUserId { get; set; }

        [Required]
        public int QuizModelId { get; set; }

        [Required]
        public int NoteFinale { get; set; }


        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser User { get; set; }

        [ForeignKey("QuizModelId")]
        public virtual QuizModel QuizModel { get; set; }



        public virtual ICollection<UserAnswer> UserAnswers { get; set; }

    }
}