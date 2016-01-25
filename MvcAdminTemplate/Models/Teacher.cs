using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studenter.Models
{
    public class Teacher : Person
    {
        public virtual ICollection<Group> Groups { get; set; }
    }
}