using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBasics.Models;

namespace WebBasics.Controllers
{
    public class BooksController : Controller
    {
        public static IList<Book> Library = new List<Book>();
        
        // GET: Books
        public ActionResult Index()
        {
            return View(Library);
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            return View(Library.First(b => b.Id == id));
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                Library.Add(book);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Library.First(b => b.Id == id));
        }

        // POST: Books/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book book)
        {
            try
            {
                // TODO: Add update logic here
                Book bb = Library.First(b => b.Id == id);
                bb.Author = book.Author;
                bb.Title = book.Title;
                bb.Isbn = book.Isbn;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Library.First(b => b.Id == id));
        }

        // POST: Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Book collection)
        {
            try
            {
                Book bb = Library.First(b => b.Id == id);
                Library.Remove(bb);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
