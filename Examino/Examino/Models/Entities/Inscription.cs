using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace Examino.Models.Entities
{
    public class Inscription
    {

        public int Id { get; set; }

        public int UserId { get; set; }

        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public DateTime InscriptionDate { get; set; }


    }
}