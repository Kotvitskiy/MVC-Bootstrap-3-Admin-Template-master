using Studenter.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Studenter.Data
{
    public class ProviderBase<T>
        where T : BaseEntity, new()
    {
        protected T Execute<T>(Func<AppContext, T> expression)
        {
            using (var context = new AppContext())
            {
                return expression(context);
            }
        }

        protected bool Execute(Func<AppContext, bool> expression)
        {
            using (var context = new AppContext())
            {
                return expression(context);
            }
        }

        public virtual bool Create(T item)
        {
            return Execute(context =>
            {
                context.Set<T>().Add(item);
                context.SaveChanges();
                return true;
            });
        }

        public virtual bool Update(T item)
        {
            return Execute(context =>
            {
                context.Set<T>().Attach(item);
                context.Entry<T>(item).State = EntityState.Modified;
                context.SaveChanges();
                return true;
            });
        }

        public virtual bool Delete(string id)
        {
            return Execute(context =>
            {
                var item = context.Set<T>().SingleOrDefault(x => x.Id == id);
                context.Set<T>().Remove(item);
                context.SaveChanges();
                return true;
            });
        }

        public virtual T Get(string id)
        {
            return Execute(context =>
            {
                return context.Set<T>().SingleOrDefault(x => x.Id == id);
            });
        }

        public virtual List<T> GetAll()
        {
            return Execute(context =>
            {
                return context.Set<T>().ToList<T>();
            });
        }
    }
}