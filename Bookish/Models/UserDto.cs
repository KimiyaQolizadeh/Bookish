using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookish.Models
{
    public class UserDto
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Passwrod { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public bool? Gender { get; set; }
        public int AccessLevel { get; set; }

        //public DateTime? LastUpdate { get; set; }
        public DateTime? Created { get; set; }
        //public int? CreateBy { get; set; }
    }
}