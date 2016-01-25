using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Studenter.Models
{
    public class Group : BaseEntity
    {
        [Display(Name = "Название группы")]
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}", Id, Name);
        }

        public Group()
        {
            Students = new List<Student>();
        }
    }
}