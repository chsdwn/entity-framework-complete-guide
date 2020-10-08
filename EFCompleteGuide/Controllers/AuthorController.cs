using System.Linq;
using EFCompleteGuide.DataAccess.Data;
using EFCompleteGuide.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCompleteGuide.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public AuthorController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var authors = _dbContext.Authors.ToList();
            return View(authors);
        }

        public IActionResult Upsert(int? id)
        {
            Author author = new Author();
            if (id == null) return View(author);

            author = _dbContext.Authors.FirstOrDefault(a => a.Author_Id == id);
            if (author == null) return NotFound();

            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Author author)
        {
            if (!ModelState.IsValid) return View(author);

            if (author.Author_Id == 0)
                _dbContext.Authors.Add(author);
            else
                _dbContext.Authors.Update(author);

            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var author = _dbContext.Authors.FirstOrDefault(a => a.Author_Id == id);
            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}