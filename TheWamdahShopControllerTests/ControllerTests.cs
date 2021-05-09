using System;
using TheWamdahShop.Interfaces;
using Xunit;
using TheWamdahShop.Controllers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using TheWamdahShop.Models;
using TheWamdahShop.Data;
using System.Collections.Concurrent;
using System.Linq;
using Moq;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace TheWamdahShopTests
{
    public class ProductControllerTests
    {
        private Mock<ILogger<ProductsController>> _logger;
        private Mock<IRepositoryWrapper> mockRepo;
        private ProductsController productsController;
        private Update update;
        private Product product;
        private List<Product> products;
        private Mock<IProduct> productMock;
        private List<IProduct> productsMock;
        private Mock<IAddProduct> addProductMock;
        private Mock<IUpdateProduct> updateProductMock;

        public ProductControllerTests()
        {
            
            productMock = new Mock<IProduct>();
            productsMock = new List<IProduct> { productMock.Object };
            updateProductMock = new Mock<IUpdateProduct>();
            product = new Product();
            products = new List<Product>();
       

            //update = new Update { Name = "CS101", Price = "Understanding Computing Basics" };

          
            _logger = new Mock<ILogger<ProductsController>>();
            var personMock = new Mock<IPerson>();
            var peopleMock = new List<IPerson>() { personMock.Object };
            var productResultsMock = new Mock<IActionResult>();

            mockRepo = new Mock<IRepositoryWrapper>();
            var allProducts = GetProducts();
            productsController = new ProductsController(_logger.Object, mockRepo.Object);
        }
        [Fact]
        public void GetAllProduts_Test()
        {
           
            mockRepo.Setup(repo => repo.Products.FindAll()).Returns(GetProducts());
            mockRepo.Setup(repo => repo.People.FindByCondition(r => r.ID == It.IsAny<int>())).Returns(GetPeople());
            //Act
           // var controllerActionResult = productsController.Get();
            //Assert
            //Assert.NotNull(controllerActionResult);
        }
        [Fact]
        public void AddProduct_Test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Products.FindByCondition(p => p.ID == It.IsAny<int>())).Returns(GetProducts());
            //Act
            //var controllerActionResult = productsController.Post(addProduct);
            //Assert
           // Assert.NotNull(controllerActionResult);
           // Assert.IsType<ActionResult<CourseViewModel>>(controllerActionResult);
        }
        [Fact]
        public void DeleteProduct_Test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Products.FindByCondition(p => p.ID == It.IsAny<int>())).Returns(GetProducts());
            mockRepo.Setup(repo => repo.Products.Delete(GetProduct()));
            //Act
            var controllerActionResult = productsController.Delete(It.IsAny<int>());
            //Assert
            Assert.NotNull(controllerActionResult);
        }
        private IEnumerable<Person> GetPeople()
        {
            return new List<Person>() {
              //  new Person { ID = 1, Product = GetProducts().ToList()[0] },
              //  new Person { ID = 2, Product = GetProducts().ToList()[1] },
            };
        }
        private Person GetPerson()
        {
            return GetPeople().ToList()[0];
        }
        private IEnumerable<Product> GetProducts()
        {
            var products = new List<Product> {
            new Product(){ID=1, Name="Chicken Burger", Price= 6},
            new Product(){ID=1, Name="Chocolate Cake", Price= 4 }
            };
            return products;
        }
        private Product GetProduct()
        {
            return GetProducts().ToList()[0];
        }
    }
    
}
