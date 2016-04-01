using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Examino.Models.Entities
{
    public class Course
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int Duration { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Inscription> Inscriptions { get; set; }

        public virtual ICollection<Chapter> Chapters { get; set; }

        public int QuizId { get; set; }  // on sauvegarde le Id du quiz final

        [ForeignKey("QuizId")]
        public virtual QuizModel QuizFinal { get; set; } 



    }
}
