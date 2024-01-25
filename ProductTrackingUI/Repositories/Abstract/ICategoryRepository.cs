using ProductTrackingUI.Models;

namespace ProductTrackingUI.Repositories.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByName(string categoryName);
        // Diğer özel metotlar
    }

}
