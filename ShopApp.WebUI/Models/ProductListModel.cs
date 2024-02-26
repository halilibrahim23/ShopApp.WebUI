using ShopApp.Entities;

namespace ShopApp.WebUI.Models
{
    public class ProductListModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
