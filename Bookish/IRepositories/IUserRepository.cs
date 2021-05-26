using Bookish.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish.IRepositories
{
    interface IUserRepository
    {
        Task<User> GetUserByID(int id);
    }
}
