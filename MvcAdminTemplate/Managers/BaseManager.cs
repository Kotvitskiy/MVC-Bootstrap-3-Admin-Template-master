using Studenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studenter.Managers
{
    public class BaseManager<T>
        where T : BaseEntity, new()
    {
        public virtual List<T> GetEntities()
        {
            return App<T>.BaseProvider.GetAll();
        }

        public virtual T Get(string id)
        {
            return App<T>.BaseProvider.Get(id);
        }

        public virtual void Create(T entity)
        {
            App<T>.BaseProvider.Create(entity);
        }

        public virtual void Update(T entity)
        {
            App<T>.BaseProvider.Update(entity);
        }

        public virtual void Delete(string id)
        {
            App<T>.BaseProvider.Delete(id);
        }
    }
}