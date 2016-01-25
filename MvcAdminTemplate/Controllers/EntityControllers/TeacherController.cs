using Studenter.Binders;
using Studenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Studenter.Controllers.EntityControllers
{
    public class TeacherController : EntityController<Teacher>
    {
        public override ActionResult Update(string id)
        {
            var teacher = App<Teacher>.Managers.Teacher.Get(id);
            return View(teacher);
        }

        public override ActionResult Update([ModelBinder(typeof(TeacherModelBinder))]Teacher entity)
        {
            return base.Update(entity);
        }
    }
}
