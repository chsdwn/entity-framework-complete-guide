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
    }
}