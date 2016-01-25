using Studenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studenter.Data
{
    public class TeacherProvider : ProviderBase<Teacher>
    {
        public override Teacher Get(string id)
        {
            return Execute(context =>
            {
                return context.Teachers.Include("Groups").SingleOrDefault(x => x.Id == id);
            });
        }
    }
}