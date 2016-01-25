using Studenter.Data;
using Studenter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Studenter.Managers
{
    public class StudentManager : BaseManager<Student>
    {   
        public void UpdateStudentGroup(Student student, string groupId)
        {
            var group = App<Group>.BaseManager.Get(groupId);

           // App<Group>.BaseManager.Delete(groupId);

            student.Group = group;            
        }

        public override void Create(Student entity)
        {
            App<Student>.Providers.Student.Create(entity);
        }

        public override List<Student> GetEntities()
        {
            return App<Student>.Providers.Student.GetAll();
        }

        public override Student Get(string id)
        {
            return App<Student>.Providers.Student.Get(id);
        }
    }
}