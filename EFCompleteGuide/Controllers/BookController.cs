using System.Linq;
using EFCompleteGuide.DataAccess.Data;
using EFCompleteGuide.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCompleteGuide.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public BookController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var books = _dbContext.Books.ToList();
            return View(books);
        }
    }
}