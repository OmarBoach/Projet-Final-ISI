using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Examino.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ApplicationUserId{get; set ;}

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser user { get; set; }

        public virtual ICollection<Inscription> Inscriptions { get; set; }

    }
}