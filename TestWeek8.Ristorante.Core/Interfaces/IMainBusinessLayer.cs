using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8.Ristorante.Core.Models;

namespace TestWeek8.Ristorante.Core.Interfaces
{
    public interface IMainBusinessLayer
    {
        IEnumerable<Menu> FetchMenu(Func<Menu, bool> filter = null);
        Menu GetMenuById(int id);
        ResultBL CreateMenu(Menu newMenu);
        ResultBL DeleteMenu(int menuId);
        Menu GetPiattoById(int id);
        IEnumerable<Piatto> FetchPiatti(Func<Piatto, bool> filter = null);
        //FetchPiattiMenu
        ResultBL CreatePiatto(Piatto newPiatto);
        ResultBL EditPiatto(Piatto modifiedPiatto);
        ResultBL DeletePiatto(int piattoId);
        User GetUserByEmail(string email);
    }
}
