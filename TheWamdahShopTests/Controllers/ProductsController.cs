using TheWamdahShop.Data;
using TheWamdahShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TheWamdahShop.Interfaces;
using Microsoft.Extensions.Logging;

namespace TheWamdahShop.Controllers
{
    [Route("[Controller]")]
    public class ProductsController : Controller
    {
        private ILogger<ProductsController> _logger;
        private  IRepositoryWrapper repository;
        public ProductsController(ILogger<ProductsController>logger, IRepositoryWrapper repositoryWrapper)
        {
            repository = repositoryWrapper;
        }
        //READ
        [Route("")]
        public IActionResult Index()
        {
            // var allproducts = dbContext.Products.ToList();
            var allproducts = repository.Products.FindAll();
            return View(allproducts);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            //var productbyID = dbContext.Products.FirstOrDefault(p => p.ID == id);
            var productbyID = repository.Products.FindByCondition(p => p.ID == id).FirstOrDefault();
            return View(productbyID);
        }

        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            //var productbyID = dbContext.Products.FirstOrDefault(p => p.ID == id);
            var productbyID = repository.Products.FindByCondition(p => p.ID == id).FirstOrDefault();
            return View(productbyID);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Product product, int id)
        {
            var productToUpdate = repository.Products.FindByCondition(p => p.ID == id).FirstOrDefault();
            // var productToUpdate = dbContext.Products.FirstOrDefault(p => p.ID == id);
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            repository.Save();
            return RedirectToAction("Index");
        }
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var productToDelete = repository.Products.FindByCondition(p => p.ID == id).FirstOrDefault();
            //var productToDelete = dbContext.Products.FirstOrDefault(p => p.ID == id);
            repository.Products.Delete(productToDelete);
            repository.Save();
            return RedirectToAction("Index");
        }
    }
}
