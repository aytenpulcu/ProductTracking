using ProductTrackingUI.Models;

namespace ProductTrackingUI.Repositories.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsInStock();
        // Diğer özel metotlar
    }

}
