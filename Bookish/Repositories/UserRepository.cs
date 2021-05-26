using Bookish.Data;
using Bookish.IRepositories;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BookishEntities _context;
        public UserRepository(BookishEntities context)
        {
            _context = context;
        }

        public async Task<User> GetUserByID(int id)
        {
            return await _context.Users.Where(x => x.ID == id).FirstOrDefaultAsync();
        }
    }
}