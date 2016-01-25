using Studenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Studenter.Controllers.EntityControllers
{
    public class StudentController : EntityController<Student>
    {
        public override ActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
                return View();

            App<Student>.Managers.Student.UpdateStudentGroup(student, student.Group.Id);

            App<Student>.Managers.Student.Create(student);

            return RedirectToAction("List");
        }

        public override ActionResult List()
        {
            var students = App<Student>.Managers.Student.GetEntities();
            return View(students);
        }
    }
}
