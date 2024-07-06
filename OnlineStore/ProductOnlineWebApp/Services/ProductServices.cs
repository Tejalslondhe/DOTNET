using BOL;
using DAL;
using ProductOnlineWebApp.Models;



namespace ProductOnlineWebApp.Services
{
    public class ProductServices: IProductService
    {
        private IDBManager dbmanager = new DBManager();
       

        public List<Product> GetProduct()
        {
           return dbmanager.GetProduct();
        }
        public Product GetProductById(int id)
        {
            return dbmanager.GetProductById(id);
        }

        public void Insert(Product product)
        {
            dbmanager.Insert(product);
            
        }

        public void Update(Product product)
        {
            dbmanager.Update(product);

        }

        public void Delete(int id)
        {
            dbmanager.Delete(id);
        }
    }
}
