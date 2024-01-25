using ProductTrackingUI.Models;

namespace ProductTrackingUI.Services.Abstract
{
    public interface IService
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Category> GetAllCategories();
    }

}
