using QuieroOrdenar.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroOrdenar.Web.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            var menu = new MenuModel();
            menu.Id = 1;
            menu.Descripcion = "Chuleta Tipica";



            return View(menu);
        }
    }
}