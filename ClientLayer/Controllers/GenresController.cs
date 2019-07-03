using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer.DAL;
using DataLayer.Library;

namespace ClientLayer.Controllers
{
    public class GenresController : Controller
    {
        private readonly RegistrationContext _context;

        public GenresController(RegistrationContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            ViewBag.Authors = _context.Authors.ToList();

            return View(await _context.Genres.ToListAsync());
        }

        [HttpPost]
        public ActionResult BookSearch(string filter, int id)
        {

            List<Book> allbooks;

            if (filter == "author")
            {
                allbooks = _context.Books.Where(a => a.Author.AuthorId == id).ToList();
            }
            else if (filter == "genre")
            {
                allbooks = _context.Books.Where(a => a.Genre.GenreId == id).ToList();
            }
            else
            {
                allbooks = null;
            }

                if (allbooks.Count <= 0)
            {
                return NotFound();
            }

            return PartialView(allbooks);
        }
    }
}
