using ProductTrackingUI.Infrastructure.Abstract;
using ProductTrackingUI.Models;
using ProductTrackingUI.Repositories.Abstract;
using ProductTrackingUI.Repositories.Concrete;

namespace ProductTrackingUI.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            ProductRepository = new Repository<Product>(_context);
            CategoryRepository = new CategoryRepository(_context);
        }

        public IRepository<Product> ProductRepository { get; }
        public IRepository<Category> CategoryRepository { get; }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
