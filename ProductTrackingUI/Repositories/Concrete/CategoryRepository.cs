using Microsoft.EntityFrameworkCore;
using ProductTrackingUI.Infrastructure;
using ProductTrackingUI.Models;
using ProductTrackingUI.Repositories.Abstract;

namespace ProductTrackingUI.Repositories.Concrete
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }

        public Category GetCategoryByName(string categoryName)
        {
            return _dbSet.FirstOrDefault(c => c.categoryName == categoryName);
        }
        // Diğer özel metot implementasyonları
    }

}
