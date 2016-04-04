using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Examino.Models.Entities
{
    public class Chapter
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // clés étrangères
        public int CourseId { get; set; }

        public int QuizId { get; set; }


        // proprietés de navigation
     
        public virtual QuizModel QuizFormatif { get; set; }

 
        public virtual Course Course { get; set; }

        public virtual ICollection<File> Files { get; set; }

    }
}