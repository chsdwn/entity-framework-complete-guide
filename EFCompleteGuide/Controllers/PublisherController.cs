using System.Linq;
using EFCompleteGuide.DataAccess.Data;
using EFCompleteGuide.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCompleteGuide.Controllers
{
    public class PublisherController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public PublisherController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Publisher publisher = new Publisher();
            if (id == null) return View(publisher);

            publisher = _dbContext.Publishers.FirstOrDefault(p => p.Publisher_Id == id);
            if (publisher == null) return NotFound();

            return View(publisher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Publisher publisher)
        {
            if (!ModelState.IsValid) return View(publisher);

            if (publisher.Publisher_Id == 0)
                _dbContext.Publishers.Add(publisher);
            else
                _dbContext.Publishers.Update(publisher);

            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var publisher = _dbContext.Publishers.FirstOrDefault(a => a.Publisher_Id == id);
            _dbContext.Publishers.Remove(publisher);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}