using System;
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

        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null) return View(category);

            category = _dbContext.Categories.FirstOrDefault(c => c.Category_Id == id);
            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (!ModelState.IsValid) return View(category);

            if (category.Category_Id == 0)
                _dbContext.Categories.Add(category);
            else
                _dbContext.Categories.Update(category);

            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var category = _dbContext.Categories.FirstOrDefault(c => c.Category_Id == id);
            _dbContext.Categories.Remove(category);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateMultiple2()
        {
            for (int i = 1; i <= 2; i++)
                _dbContext.Categories.Add(new Category { Name = Guid.NewGuid().ToString() });
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult CreateMultiple5()
        {
            for (int i = 1; i <= 5; i++)
                _dbContext.Categories.Add(new Category { Name = Guid.NewGuid().ToString() });
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}