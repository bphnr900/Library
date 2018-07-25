using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;
using System.Data.Entity;

namespace Library.Controllers
{
    public class BeginController : Controller
    {
        private LibraryContext db = new LibraryContext();
        // GET: Begin
        public ActionResult Index()
        {
            return Content("Hello,World");
        }
        public ActionResult Show()
        {
            ViewBag.Message = "Hello,world";
            return View();
        }
        public ActionResult List()
        {
            var books = from a in db.Books
                        join b in db.Groups on a equals b.GroupId
                        join c in db.BookTypes on a equals c.BookTypeId
                        select new LibraryListModel
                        {
                            
                        };
            return View(books);
        }
        public ActionResult Search(string keyword)
        {
            var books = from a in db.Books
                       select a;
            if (!string.IsNullOrEmpty(keyword))
            {
                books = books.Where(a => a.Name.Contains(keyword));
            }
            return View(books);
        }
        public ActionResult SelectSample()
        {
            //Create db context object here
            LibraryContext dbcontext = new LibraryContext();
            //Get the value from database and then set it to ViewBag to pass it View
            IEnumerable<SelectListItem> items = dbcontext.BookTypes.Select(c => new SelectListItem
            {
                Value = c.Type,
                Text = c.TypeName
            });
            ViewBag.Type = items;
            return View();
        }
    }
}