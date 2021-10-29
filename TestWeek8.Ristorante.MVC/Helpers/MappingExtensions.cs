using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeek8.Ristorante.Core.Models;
using TestWeek8.Ristorante.MVC.Models;

namespace TestWeek8.Ristorante.MVC.Helpers
{
    public static class MappingExtensions
    {
        public static MenuViewModel ToViewModel(this Menu menu)
        {
            return new MenuViewModel
            {
                Id = menu.Id,
                Nome = menu.Nome
              
            };
        }

        public static PiattoViewModel ToPiattoViewModel(this Piatto piatto)
        {
            return new PiattoViewModel
            {
                Id = piatto.Id,
                Nome = piatto.Nome,
                Prezzo = piatto.Prezzo,
                Tipologia = piatto.Tipologia
            };
        }


        public static IEnumerable<MenuViewModel> ToListViewModel(this IEnumerable<Menu> menus)
        {
            return menus.Select(m => m.ToViewModel());
        }

        public static IEnumerable<PiattoViewModel> ToListPiattiViewModel(this IEnumerable<Piatto> piatti)
        {
            return piatti.Select(p => p.ToPiattoViewModel());
        }


        public static Menu ToMenu(this MenuViewModel menuViewModel)
        {
            return new Menu
            {
                Id = menuViewModel.Id,
                Nome = menuViewModel.Nome,
                
                
                
            };
        }

       
    }
}
