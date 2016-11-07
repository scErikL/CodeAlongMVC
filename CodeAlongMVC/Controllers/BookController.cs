using CodeAlongMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CodeAlongMVC.Controllers
{
    public class BookController : Controller
    {
        private BookRepository repo;
        
        public BookController(){
            this.repo = new BookRepository();
        }

        // GET: Book
        public ActionResult Index()
        {
            var books = repo.GetAllBooks(); 
            return View(books);
        }

        // GET: Book/Details/Id
        public ActionResult Details(int id=-1)
        {
            return View(repo.GetBookById(id));
        }

        public String TestMethod()
        {
            var js = new JavaScriptSerializer();
            return js.Serialize(repo.GetAllBooks());
        }

        public void Test()
        {
            Response.Redirect("Details/4");
        }

    }
}