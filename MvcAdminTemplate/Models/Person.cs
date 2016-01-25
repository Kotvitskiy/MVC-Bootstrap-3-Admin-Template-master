using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Studenter.Models
{
    public abstract class Person : BaseEntity
    {        
        [Display(Name="Имя")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        public string SecondName { get; set; }

        public string Name { get { return string.Format("{0} {1}", FirstName, SecondName); } }
    }
}