using ApplicationLayer.Models;

namespace ApplicationLayer.Services
{
    public interface IProductService
    {
        void Add(AddNewProductViewModel model);
    }
}