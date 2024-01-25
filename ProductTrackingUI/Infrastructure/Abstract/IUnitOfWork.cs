using ProductTrackingUI.Models;
using ProductTrackingUI.Repositories.Abstract;

namespace ProductTrackingUI.Infrastructure.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> ProductRepository { get; }
        IRepository<Category> CategoryRepository { get; }

        void Save();
    }

}
