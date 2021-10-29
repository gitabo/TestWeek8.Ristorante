using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8.Ristorante.Core.Interfaces;
using TestWeek8.Ristorante.Core.Models;

namespace TestWeek8.Ristorante.EF.Repositories
{
    public class RepositoryUserEF : IRepositoryUser
    {
        private readonly RistoranteContext ctx;

        public RepositoryUserEF(RistoranteContext context)
        {
            this.ctx = context;
        }

        public bool AddItem(User item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Fetch(Func<User, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public User GetByEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return null;
            return ctx.Users.FirstOrDefault(u => u.Email.Equals(email));
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(User updatedItem)
        {
            throw new NotImplementedException();
        }
    }
}
