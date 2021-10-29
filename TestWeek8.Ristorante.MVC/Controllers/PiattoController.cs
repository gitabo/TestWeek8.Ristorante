using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeek8.Ristorante.Core.Interfaces;
using TestWeek8.Ristorante.Core.Models;
using TestWeek8.Ristorante.MVC.Models;

namespace TestWeek8.Ristorante.MVC.Controllers
{
    public class PiattoController : Controller
    {
        private readonly IMainBusinessLayer mainBl;
        public PiattoController(IMainBusinessLayer bl)
        {
            this.mainBl = bl;
        }

        public IActionResult Create()
        {
            LoadViewBag();
            return View(new PiattoViewModel());
        }
        //da finire

        //HTTP POST /Create
        //[HttpPost]
        //public IActionResult Create(PiattoViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }
        //    if (model == null)
        //    {
        //        return View("ExceptionError", new ResultBL(false, "Error!"));
        //    }
        //    //Mappatura
        //    Piatto newPiatto = model.ToPiatto();
        //    var result = mainBl.CreatePiatto(newPiatto);
        //    if (!result.Success)
        //    {
        //        return View("ExceptionError", result);
        //    }
        //    return RedirectToAction(nameof(Index));
        //}

        public IActionResult Index()
        {
            return View();
        }


        private void LoadViewBag()
        {

            ViewBag.Categories = new SelectList(new[]{
                "Primo",
                "Secondo",
                "Contorno",
                "Dolce"
            });

        }
    }
}
