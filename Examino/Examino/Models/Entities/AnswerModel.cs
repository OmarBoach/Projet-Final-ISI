using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Examino.Models.Entities
{
    public class AnswerModel
    {
        [Key]
        public int Id { get; set; }

      
        public string LabelAnswer { get; set; }

       
        public bool Answer { get; set; }

        public string PicturePath { get; set; }

        public int QuestionModelId { get; set; }


      
        public virtual QuestionModel QuestionModel { get; set; }

    }
}