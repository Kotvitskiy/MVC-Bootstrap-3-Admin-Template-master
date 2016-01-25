using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Studenter.Models
{
    public class Student : Person
    {
        [Display(Name="Группа")]        
        public Group Group { get; set; }
    }
}