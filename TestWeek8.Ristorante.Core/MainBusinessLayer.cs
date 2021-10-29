using System;
using System.Collections.Generic;
using TestWeek8.Ristorante.Core.Interfaces;
using TestWeek8.Ristorante.Core.Models;

namespace TestWeek8.Ristorante.Core
{
    public class MainBusinessLayer : IMainBusinessLayer
    {
        private readonly IRepositoryMenu repoMenu;
        private readonly IRepositoryPiatto repoPiatto;
        private readonly IRepositoryUser repoUser;

        public MainBusinessLayer(IRepositoryMenu repoMenu, IRepositoryPiatto repoPiatto,
                                IRepositoryUser repoUser)
        {
            this.repoMenu = repoMenu;
            this.repoPiatto = repoPiatto;
            this.repoUser = repoUser;
        }

        public ResultBL CreateMenu(Menu newMenu)
        {
            if (newMenu == null)
            {
                return new ResultBL(false, "Invalid menu");
            }
            var result = repoMenu.AddItem(newMenu);
            if (!result)
                return new ResultBL(result, "Something wrong!");
            return new ResultBL(result, "Ok!");
        }

        public ResultBL CreatePiatto(Piatto newPiatto)
        {
            throw new NotImplementedException();
        }

        public ResultBL DeleteMenu(int menuId)
        {
            if (menuId <= 0)
                return new ResultBL(false, "Invalid ID");
            var result = repoMenu.DeleteItem(menuId);
            if (!result)
                return new ResultBL(result, "Something wrong");
            return new ResultBL(result, "Ok!");
        }

        public ResultBL DeletePiatto(int piattoId)
        {
            throw new NotImplementedException();
        }

        public ResultBL EditPiatto(Piatto modifiedPiatto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Menu> FetchMenu(Func<Menu, bool> filter = null)
        {
            return this.repoMenu.Fetch(filter);
        }

        public IEnumerable<Piatto> FetchPiatti(Func<Piatto, bool> filter = null)
        {
            throw new NotImplementedException();
        }

        public Menu GetMenuById(int id)
        {
            if (id <= 0)
                return null;
            return this.repoMenu.GetById(id);
        }

        public Menu GetPiattoById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return null;
            return repoUser.GetByEmail(email);
        }
    }
}
