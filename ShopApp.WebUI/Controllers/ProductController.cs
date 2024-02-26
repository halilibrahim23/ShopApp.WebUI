using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entities;
using ShopApp.WebUI.Models;

namespace ShopApp.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
            return View(new ProductListModel()
            {
                Products = _productService.GetAll(),
                //Categories = _categoryService.GetAll(),

            });
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateProduct(ProductModel model)
        {
            var entity = new Product()
            {
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Stock = model.Stock,
                Price = model.Price
            };

            _productService.Create(entity);
            return RedirectToAction("Index");
        }
        
        public IActionResult EditProduct(int? id) 
        {
            if (id==null)
            {
                return NotFound();
            }
            var entity=_productService.GetById((int)id);

            if (entity==null)
            {
                return NotFound();
            }

            var model = new ProductModel()
            {
                Id=entity.Id,
                Name=entity.Name,
                ImageUrl=entity.ImageUrl,
                Stock=entity.Stock,
                Price=entity.Price

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditProduct(ProductModel model)
        {
            var entity = _productService.GetById(model.Id);
            if (entity == null)
            {
                return NotFound();
            }
            entity.Name = model.Name;
            entity.ImageUrl = model.ImageUrl;
            entity.Stock = model.Stock;
            entity.Price = model.Price;
            _productService.Update(entity);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteProduct(int productId) 
        { 
            var entity=_productService.GetById(productId);
            if (entity != null)
            {
                _productService.Delete(entity);
                
            }
            return RedirectToAction("Index");
        }



    }
}
