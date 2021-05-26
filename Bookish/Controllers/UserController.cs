using Bookish.Data;
using Bookish.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Bookish.Controllers
{
    public class UserController : ApiController
    {
        private readonly BookishEntities _context;
        public UserController(BookishEntities context)
        {
            _context = context;
        }

        //public async Task<AuthorDto> GetAuthorByIdAsync(int id)
        //{
        //    return await _context.Authors.FindAsync(id);
        //}
    }
}
