using Studenter.Managers;
using Studenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Studenter.Controllers.EntityControllers
{
    public class EntityController<T> : Controller
        where T : BaseEntity, new()
    {
        private static BaseManager<T> Manager;

        public EntityController()
        {
            Manager = App<T>.BaseManager;
        }

        [HttpGet]
        public virtual ActionResult List()
        {
            var entities = Manager.GetEntities();
            return View(entities);
        }

        [HttpGet]
        public virtual ActionResult Create()
        {
            var entity = new T();
            return View(entity);
        }

        [HttpPost]
        public virtual ActionResult Create(T entity)
        {
            if (!ModelState.IsValid)
                return View(entity);

            Manager.Create(entity);
            return RedirectToAction("List");
        }

        [HttpPost]
        public virtual ActionResult Delete(string id)
        {
            if (!string.IsNullOrEmpty(id))
                return RedirectToAction("List");

            Manager.Delete(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        public virtual ActionResult Update(string id)
        {
            if (!string.IsNullOrEmpty(id))
                return RedirectToAction("List");

            var entityToUpdate = Manager.Get(id);
            return View(entityToUpdate);
        }

        [HttpPost]
        public virtual ActionResult Update(T entity)
        {
            if (!ModelState.IsValid)
                return View(entity);

            Manager.Update(entity);
            return RedirectToAction("List");
        }

    }
}
