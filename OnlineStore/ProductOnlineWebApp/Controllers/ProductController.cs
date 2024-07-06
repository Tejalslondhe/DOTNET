using Microsoft.AspNetCore.Mvc;
using ProductOnlineWebApp.Services;
using ProductOnlineWebApp.Models;
using BOL;
namespace ProductOnlineWebApp.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productservice;

        public ProductController(IProductService productService)
        {
            this.productservice = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

       

        public IActionResult Getproduct()
        {
            List<Product> products = productservice.GetProduct();
            return View(products);
        }

        
        public IActionResult GetProductById(int id, ProductServices productServices)
        {
            Product product = productServices.GetProductById(id);

            if(product == null) {
               
                    return NotFound();
                }
             else
                {
                    return Json(product);
                }
        }


        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        /*public IActionResult Insert(string title, string description, string unit_price, string image_url, string quantity)
        {
            return Insert(title, description, unit_price, image_url, quantity);
        }*/

        [HttpPost]
        public IActionResult Insert(string title,string description, string unit_price,string image_url,string quantity)
        {
                double price = double.Parse(unit_price); 
                int qty = int.Parse(quantity);

                Product product = new Product(title, description, price, image_url, qty);
                productservice.Insert(product);
                return RedirectToAction("Insert");
          
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(string id,string title, string description, string unit_price, string image_url, string quantity)
            {
                int pid = int.Parse(id);
                double price = double.Parse(unit_price);
                int qty = int.Parse(quantity);

                Product product = new Product(pid, title, description, price, image_url, qty);
                productservice.Update(product);
                return View();

            }


        public IActionResult Delete(int id)
        {
                productservice.Delete(id);
                return RedirectToAction("Index");
        }

        

    }
}
