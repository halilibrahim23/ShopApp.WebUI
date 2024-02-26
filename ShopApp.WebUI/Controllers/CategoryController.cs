using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View(new CategoryListModel()
            {
                Categories=_categoryService.GetAll()
            });
        }
        [HttpGet]
        public IActionResult EditCategory(int? id) 
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _categoryService.GetById((int)id);

            if (entity == null)
            {
                return NotFound();
            }

            var model = new CategoryModel()
            {
                Id = entity.Id,
                CategoryName = entity.CategoryName,
              

            };
            return View(model);

        }
        [HttpPost]
        public IActionResult EditCategory(CategoryModel model)
        {
            var entity = _categoryService.GetById(model.Id);
            if (entity == null)
            {
                return NotFound();
            }
            entity.CategoryName = model.CategoryName;
           
            _categoryService.Update(entity);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateCategory(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryModel model)
        {
            var entity = new Category()
            {
                CategoryName = model.CategoryName,
                
            };

            _categoryService.Create(entity);
            return RedirectToAction("Index");
        }
        [HttpPost]
        [HttpPost]
        public IActionResult DeleteCategory(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);
            if (entity != null)
            {
                _categoryService.Delete(entity);

            }
            return RedirectToAction("Index");
        }



    }
}
