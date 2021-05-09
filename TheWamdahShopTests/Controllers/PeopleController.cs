using TheWamdahShop.Data;
using TheWamdahShop.Models;
using TheWamdahShop.Models.Binding;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TheWamdahShop.Interfaces;
using Microsoft.Extensions.Logging;

namespace TheWamdahShop.Controllers
{
    [Route("[Controller]")]
    public class PeopleController : Controller
    {
        private ILogger<PeopleController> _logger;
        private IRepositoryWrapper repository;
        public PeopleController(ILogger<PeopleController>logger,IRepositoryWrapper repositoryWrapper)
        {
            repository = repositoryWrapper;
        }
        #region Person

        [Route("")]
        public IActionResult Index()
        {
            var allPeople = repository.People.FindAll();
            //var allPeople = dbContext.People.ToList();
            return View(allPeople);
        }
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            var personById = repository.People.FindByCondition(p => p.ID == id);
           // var personById = dbContext.People.FirstOrDefault(p => p.ID == id);
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
            repository.People.Create(personToCreate);
            repository.Save();
           // dbContext.People.Add(personToCreate);
            //dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("update/{id:int}")]
        public IActionResult Update(int id)
        {
            var personByID = repository.People.FindByCondition(p => p.ID == id).FirstOrDefault();
            //var personbyID = dbContext.People.FirstOrDefault(p => p.ID == id);
            return View(personByID);
        }
        [HttpPost]
        [Route("update/{id:int}")]
        public IActionResult Update(Person person, int id)
        {
            var personToUpdate = repository.People.FindByCondition(p => p.ID == id).FirstOrDefault();
            // var personToUpdate = dbContext.People.FirstOrDefault(p => p.ID == id);
            personToUpdate.Title = person.Title;
            personToUpdate.Name = person.Name;
            personToUpdate.Address = person.Address;
            personToUpdate.Email = person.Email;
            repository.Save();
            //dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)
        {
            var personToDelete = repository.People.FindByCondition(p => p.ID == id).FirstOrDefault();
            // var personToDelete = dbContext.People.FirstOrDefault(p => p.ID == id);
            //dbContext.People.Remove(personToDelete);
            //dbContext.SaveChanges();
            repository.People.Delete(personToDelete);
            repository.Save();
            return RedirectToAction("Index");
        }
        #endregion
        #region Product
   
        [Route("addproduct/{personID:int}")]
        public IActionResult CreateProduct(int personID)
        {
            var person = repository.People.FindByCondition(p => p.ID == personID).FirstOrDefault();
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
                Person = repository.People.FindByCondition(p => p.ID == personID).FirstOrDefault(),
                PictureURL = "https://i.kinja-img.com/gawker-media/image/upload/s--UtjsCMpA--/c_scale,f_auto,fl_progressive,q_80,w_800/fnltdcfgfriq10dspggu.jpg",
                CreatedAt = DateTime.Now
            };
            repository.Products.Create(productToCreate);
            repository.Save();
            //dbContext.Products.Add(productToCreate);
            //dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("{id:int}/products")]
        public IActionResult ViewProducts(int id)
        {
            var person = repository.People.FindByCondition(p => p.ID == id).FirstOrDefault();
            var products = repository.Products.FindByCondition(p => p.Person.ID == id).ToList();
            ViewBag.PersonName = person.Name;
            return View(products);
        }
        #endregion

    }
}
