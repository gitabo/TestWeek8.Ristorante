using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8.Ristorante.Core.Interfaces;
using TestWeek8.Ristorante.Core.Models;

namespace TestWeek8.Ristorante.EF.Repositories
{
    public class RepositoryMenuEF : IRepositoryMenu
    {
        private readonly RistoranteContext ctx;

        public RepositoryMenuEF(RistoranteContext context)
        {
            this.ctx = context;
        }
        
        public bool AddItem(Menu item)
        {
            if (item == null)
                return false;
            ctx.Menus.Add(item);
            ctx.SaveChanges();
            return true;
        }

        public bool DeleteItem(int id)
        {
            if (id <= 0)
                return false;

            //menu da cancellare
            var menuToDelete = ctx.Menus.Find(id);
            if (menuToDelete == null)
                return false;
            ctx.Menus.Remove(menuToDelete);
            ctx.SaveChanges();
            return true;
        }

        public IEnumerable<Menu> Fetch(Func<Menu, bool> filter = null)
        {
            if (filter != null)
                return this.ctx.Menus.Where(filter);
            return ctx.Menus;
        }

        public Menu GetById(int id)
        {
            if (id <= 0)
                return null;
            return ctx.Menus.Include(p => p.Piatti).FirstOrDefault(m => m.Id == id);
        }

        public bool UpdateItem(Menu updatedItem)
        {
            throw new NotImplementedException();
        }
    }
}
