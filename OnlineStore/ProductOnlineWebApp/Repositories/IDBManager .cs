using BOL;

namespace DAL;

public interface IDBManager
{
    List<Product> GetProduct();

    Product GetProductById(int id);

    void Insert(Product product);

    void Update(Product product);

    void Delete(int id);

}
