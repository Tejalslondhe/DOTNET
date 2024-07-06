using BOL;
using ProductOnlineWebApp.Models;
namespace ProductOnlineWebApp.Services
{
    public interface IProductService
    {
        List<Product> GetProduct();

        Product GetProductById(int id);

        void Insert(Product product);

        void Update(Product product);

        void Delete(int id);


    }
}
