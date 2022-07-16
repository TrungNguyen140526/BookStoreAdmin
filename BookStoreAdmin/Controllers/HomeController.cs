
using BookStoreAdmin.Models;
using BookStoreAdmin.Objects;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStoreAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookManagerContext _db;

        private readonly ILogger<HomeController> _logger;



        public HomeController(ILogger<HomeController> logger, BookManagerContext db)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Book> ojbBookList = _db.Books;
            return View(ojbBookList);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book obj)
        {

            obj.Ratting = 0;
            obj.DatePublished = DateTime.Now;

            _db.Books.Add(obj);
            _db.SaveChanges();


            return RedirectToAction("Index");
        }

        //GET
        public IActionResult Edit(String? id)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }
            var BookFromDb = _db.Books.Find(id);

            if (BookFromDb == null)
            {
                return NotFound();
            }
            return View(BookFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book obj)
        {
            try
            {
                obj.Ratting = 0;
                obj.DatePublished = DateTime.Now;

                _db.Books.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(String? id)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }
            var BookFromDb = _db.Books.Find(id);

            if (BookFromDb == null)
            {
                return NotFound();
            }
            return View(BookFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Book obj)
        {
            try
            {
                var BookFromDb = _db.Books.Find(obj.BookId);

                if (BookFromDb == null)
                {
                    return NotFound();
                }



                _db.Books.Remove(BookFromDb);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

            }
            return View(obj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}