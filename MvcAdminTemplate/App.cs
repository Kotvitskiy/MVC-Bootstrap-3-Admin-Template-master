using Studenter.Data;
using Studenter.Managers;
using Studenter.Models;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Studenter
{
    public static class App<T>
        where T : BaseEntity, new()
    {
        public static ProviderBase<T> BaseProvider
        {
            get { return new ProviderBase<T>(); }
        }

        public static BaseManager<T> BaseManager
        {
            get { return new BaseManager<T>(); }
        }

        public static class Providers
        {
            public static StudentProvider Student { get { return new StudentProvider(); } }

            public static TeacherProvider Teacher { get { return new TeacherProvider();} }
        }

        public static class Managers
        {
            public static StudentManager Student { get { return new StudentManager(); } }

            public static TeacherManager Teacher { get { return new TeacherManager(); } }
        }
    }
}