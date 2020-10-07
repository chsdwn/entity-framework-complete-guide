using System.Collections.Generic;
using System.Linq;
using EFCompleteGuide.DataAccess.Data;
using EFCompleteGuide.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCompleteGuide.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Category> categories = _dbContext.Categories.ToList();

            return View(categories);
        }
    }
}