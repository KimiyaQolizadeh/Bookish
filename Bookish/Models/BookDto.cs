using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookish.Models
{
    public class BookDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string ISBN { get; set; }
        public int? PublicationYear { get; set; }
        public int PublisherID { get; set; }

        //public DateTime? LastUpdate { get; set; }
        public DateTime? Created { get; set; }
        //public int? CreateBy { get; set; }


        public string PublisherName { get; set; }
        public List<string> AuthorsName { get; set; }

        //public PublisherDto Publisher { get; set; }
        //public List<AuthorDto> Authors { get; set; }


    }
}