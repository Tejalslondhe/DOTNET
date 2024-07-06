using BOL;
namespace DAL;

public class DBManager:IDBManager
{

    public List<Product> GetProduct()
    {
        using (var context = new EStoreCollectionContext())
        {
            //LINQ
            var products = from product in context.products
                           select product;
            return products.ToList<Product>();
        }

    }
    public void Delete(int id)
    {
        using (var context = new EStoreCollectionContext())
        {
            context.products.Remove(context.products.Find(id));
            context.SaveChanges();
        }
    }

    

    public Product GetProductById(int id)
    {
        using (var context = new EStoreCollectionContext())
        {
            var product = context.products.Find(id);
            return product;
        }
    }

    public void Insert(Product product)
    {
        using (var context = new EStoreCollectionContext())
        {
            {
                context.products.Add(product);
                context.SaveChanges();
            }
        }
    }

    public void Update(Product product)
    {
        using(var context = new EStoreCollectionContext())
        {
            var newProduct = context.products.Find(product.id);
            newProduct.title = product.title;
            newProduct.description = product.description;
            newProduct.unit_price = product.unit_price;
            newProduct.image_url = product.image_url;
            newProduct.quantity = product.quantity;
            context.SaveChanges();
         
        }
    }

   




}
