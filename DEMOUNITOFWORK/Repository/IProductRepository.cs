using DEMOUNITOFWORK.Models;

namespace DEMOUNITOFWORK.Repository
{
    public interface IProductRepository
    {
        List<Order> GetProducts();
        Order GetProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
