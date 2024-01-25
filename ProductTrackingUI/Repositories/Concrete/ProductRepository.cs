using Microsoft.EntityFrameworkCore;
using ProductTrackingUI.Models;
using ProductTrackingUI.Repositories.Abstract;

namespace ProductTrackingUI.Repositories.Concrete
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Product> GetProductsInStock()
        {
            return _dbSet.Where(p => p.stock > 0).ToList();
        }
        // Diğer özel metot implementasyonları
    }

}
