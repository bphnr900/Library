using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class SampleController : Controller
    {
        private LibraryContext db = new LibraryContext();
        // GET: Sample
        public ActionResult Index()
        {
            ViewBag.Message = "Sample";
            return View();
        }
        public ActionResult Select()
        {
            ViewBag.SelectOption = new SelectListItem[]
            {
                new SelectListItem(){Value="1",Text="大阪"},
                new SelectListItem(){Value = "2",Text="兵庫"},
                new SelectListItem(){Value="3",Text="京都"}
            };
            return View();
        }
        public ActionResult Show()
        {
            return View(db.Books);
        }
    }
}