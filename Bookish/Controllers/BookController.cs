using Bookish.Data;
using Bookish.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Bookish.Controllers
{
    public class BookController : ApiController
    {
        private readonly BookishEntities _context;
        public BookController()
        {
            _context = new BookishEntities();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            try
            {
                if (id <= 0)
                    return BadRequest("Invalid id");

                Book book = await _context.Books
                    .Where(x => x.ID == id)
                    .AsNoTracking()
                    .Include(b => b.Publisher)
                    .FirstOrDefaultAsync();

                if (book == null)
                    return BadRequest();

                BookDto response = new BookDto()
                {
                    ID = book.ID,
                    ISBN = book.ISBN,
                    OriginalTitle = book.OriginalTitle,
                    PublicationYear = book.PublicationYear,
                    Title = book.Title,
                    PublisherID = book.PublisherID,
                    PublisherName = book.Publisher.Name,
                    AuthorsName = book.BookAuthors.Select(x => x.Author.FirstName + " " + x.Author.LastName).ToList()
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

    }
}
