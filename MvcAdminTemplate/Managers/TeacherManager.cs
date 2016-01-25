using Studenter.Data;
using Studenter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Studenter.Managers
{
    public class TeacherManager : BaseManager<Teacher>
    {
        public override Teacher Get(string id)
        {
            return App<Teacher>.Providers.Teacher.Get(id);
        }
    }
}