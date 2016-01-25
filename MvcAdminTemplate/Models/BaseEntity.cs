using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studenter.Models
{
    public class BaseEntity
    {
        public string Id { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}