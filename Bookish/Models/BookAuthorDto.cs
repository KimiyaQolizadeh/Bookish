using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookish.Models
{
    public class BookAuthorDto
    {
        public int ID { get; set; }
        public int BookID { get; set; }
        public int AuthorID { get; set; }

        //public DateTime? LastUpdate { get; set; }
        public DateTime? Created { get; set; }
        //public int? CreateBy { get; set; }

        public AuthorDto Author { get; set; }
        public BookDto Book { get; set; }
    }
}