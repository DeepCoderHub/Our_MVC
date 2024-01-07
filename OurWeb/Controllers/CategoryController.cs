using Microsoft.AspNetCore.Mvc;
using OurWeb.Data;
using OurWeb.Models;

namespace OurWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            // var objCategoryList = _db.Categories.ToList(); // var and List<Category> works same so it's depend on you to use.
            List<Category> objCategoryList=_db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            //if (obj.Name == obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name");
            //}
           
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Category");
            }
            return View(obj);
        }
    }
}
