using TheWamdahShop.Data;
using TheWamdahShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TheWamdahShop.Controllers
{
    [Route("[Controller]")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext dbContext;
        public ProductsController(AppDbContext appDbContext)
        {
            dbContext = appDbContext;
        }
        //READ
        [Route("")]
        public IActionResult Index()
        {
            var allproducts = dbContext.Products.ToList();
            return View(allproducts);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var productbyID = dbContext.Products.FirstOrDefault(p => p.ID == id);
            return View(productbyID);
        }

        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var productbyID = dbContext.Products.FirstOrDefault(p => p.ID == id);
            return View(productbyID);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Product product, int id)
        {
            var productToUpdate = dbContext.Products.FirstOrDefault(p => p.ID == id);
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var productToDelete = dbContext.Products.FirstOrDefault(p => p.ID == id);
            dbContext.Products.Remove(productToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
