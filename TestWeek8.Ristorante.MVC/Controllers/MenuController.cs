using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeek8.Ristorante.Core.Interfaces;
using TestWeek8.Ristorante.Core.Models;
using TestWeek8.Ristorante.MVC.Helpers;
using TestWeek8.Ristorante.MVC.Models;

namespace TestWeek8.Ristorante.MVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMainBusinessLayer mainBl;
        public MenuController(IMainBusinessLayer bl)
        {
            this.mainBl = bl;
        }

        public IActionResult Create()
        {
            return View(new MenuViewModel());
        }


        //HTTP POST Menu/Create
        [HttpPost]
        public IActionResult Create(MenuViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            if (model == null)
            {
                return View("ExceptionError", new ResultBL(false, "Error!"));
            }
            //Mappatura 
            Menu newMenu = model.ToMenu();
            var result = mainBl.CreateMenu(newMenu);
            if (!result.Success)
            {
                return View("ExceptionError", result);
            }
            return RedirectToAction(nameof(Index));
        }


        [Route("Menu/DeleteJS/{id}")]
        public IActionResult DeleteJS(int id)
        {
            if (id <= 0)
                return Json(false);

            // chiamate al BL ...
            var result = mainBl.DeleteMenu(id);

            return Json(result.Success);
        }

        //GET Employees/Detail/{id}
        public IActionResult Detail(int id)
        {
            if (id <= 0)
                return View("Index");
            var menu = this.mainBl.GetMenuById(id);
            var piatti = menu.Piatti;
            if (menu == null)
                return View("Index");
            var resultMapped = piatti.ToListPiattiViewModel();
            return View(resultMapped);
        }

        public IActionResult Index()
        {
            var result = mainBl.FetchMenu();

            var resultMapping = result.ToListViewModel();
            return View(resultMapping);
        }
    }
}
