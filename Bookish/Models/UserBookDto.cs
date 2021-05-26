using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookish.Models
{
    public class UserBookDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
        public int Status { get; set; }

        //public DateTime? LastUpdate { get; set; }
        public DateTime? Created { get; set; }
        //public int? CreateBy { get; set; }

        public BookDto Book { get; set; }
        public UserDto User { get; set; }
    }
}