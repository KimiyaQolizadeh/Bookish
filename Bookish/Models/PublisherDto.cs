using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookish.Models
{
    public class PublisherDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public DateTime? LastUpdate { get; set; }
        public DateTime? Created { get; set; }
        //public int? CreateBy { get; set; }
    }
}