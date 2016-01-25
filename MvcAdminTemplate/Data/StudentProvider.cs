using Studenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studenter.Data
{
    public class StudentProvider : ProviderBase<Student>
    {
        public override bool Create(Student item)
        {
            return Execute(context =>
            {
                context.Set<Student>().Add(item);
                context.Entry(item.Group).State = System.Data.EntityState.Modified;
                context.SaveChanges();
                return true;
            });
        }

        public override Student Get(string id)
        {
            return Execute(context =>
            {
                return context.Students.Include("Group").SingleOrDefault(x => x.Id == id);
            });
        }

        public override List<Student> GetAll()
        {
            return Execute(context =>
            {
                return context.Students.Include("Group").ToList();
            });
        }
    }
}