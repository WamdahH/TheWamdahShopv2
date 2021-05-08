using TheWamdahShop.Data;
using TheWamdahShop.Models;
using TheWamdahShop.Models.Binding;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace TheWamdahShop.Controllers
{
    [Route("[Controller]")]
    public class PeopleController : Controller
    {
        private readonly AppDbContext dbContext;
        public PeopleController(AppDbContext appDbContext)
        {
            dbContext = appDbContext;
        }
        #region Person

        [Route("")]
        public IActionResult Index()
        {
            var allPeople = dbContext.People.ToList();
            return View(allPeople);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var personById = dbContext.People.FirstOrDefault(p => p.ID == id);
            return View(personById);
        }
    
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(AddPersonBindingModel bindingModel)
        {
            var personToCreate = new Person
            {
                Title = bindingModel.Title,
                Name = bindingModel.Name,
                Address = bindingModel.Address,
                Email = bindingModel.Email,
                CreatedAt = DateTime.Now
            };
            dbContext.People.Add(personToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var personbyID = dbContext.People.FirstOrDefault(p => p.ID == id);
            return View(personbyID);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Person person, int id)
        {
            var personToUpdate = dbContext.People.FirstOrDefault(p => p.ID == id);
            personToUpdate.Title = person.Title;
            personToUpdate.Name = person.Name;
            personToUpdate.Address = person.Address;
            personToUpdate.Email = person.Email;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var personToDelete = dbContext.People.FirstOrDefault(p => p.ID == id);
            dbContext.People.Remove(personToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion
        #region Product
   
        [Route("addproduct/{personID:int}")]
        public IActionResult CreateProduct(int personID)
        {
            var person = dbContext.People.FirstOrDefault(c => c.ID == personID);
            ViewBag.PersonName = person.Name;
            return View();
        }
        [HttpPost]
        [Route("addproduct/{personID:int}")]
        public IActionResult CreateProduct(AddProductBindingModel bindingModel, int personID)
        {
            bindingModel.PersonID = personID;
            var productToCreate = new Product
            {
                Name = bindingModel.Name,
                Price = bindingModel.Price,
                Person = dbContext.People.FirstOrDefault(p => p.ID == personID),
                PictureURL = "https://i.kinja-img.com/gawker-media/image/upload/s--UtjsCMpA--/c_scale,f_auto,fl_progressive,q_80,w_800/fnltdcfgfriq10dspggu.jpg",
                CreatedAt = DateTime.Now
            };
            dbContext.Products.Add(productToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("{id:int}/products")]
        public IActionResult ViewProducts(int id)
        {
            var person = dbContext.People.FirstOrDefault(p => p.ID == id);
            var products = dbContext.Products.Where(p => p.Person.ID == id).ToList();
            ViewBag.PersonName = person.Name;
            return View(products);
        }
        #endregion

    }
}
