using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Examino.Models.Entities
{
    public class File
    {

        public int Id { get; set; }

        public string FileName { get; set; }

        public string path { get; set; }


        public int ChapterId { get; set; }


        public virtual Chapter chapter { get; set; }

    }
}
