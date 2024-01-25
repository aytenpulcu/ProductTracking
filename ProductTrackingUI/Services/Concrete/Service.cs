using ProductTrackingUI.Infrastructure.Abstract;
using ProductTrackingUI.Models;
using ProductTrackingUI.Services.Abstract;

namespace ProductTrackingUI.Services.Concrete
{
    public class Service : IService
    {
        private readonly IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _unitOfWork.ProductRepository.GetAll();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _unitOfWork.CategoryRepository.GetAll();
        }
    }

}
