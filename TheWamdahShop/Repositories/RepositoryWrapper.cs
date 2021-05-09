using TheWamdahShop.Data;
using TheWamdahShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using TheWamdahShop.Repositories;

namespace StudentsAndCourses.Library.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        AppDbContext _repoContext;
        public RepositoryWrapper(AppDbContext repoContext)
        {
            _repoContext = repoContext;
        }
        IProductRepository _products;

        IPersonRepository _people;

        public IProductRepository Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new ProductRepository(_repoContext);
                }
                return _products;
            }
        }
        public IPersonRepository People
        {
            get
            {
                if (_people == null)
                {
                    _people = new PersonRepository(_repoContext);
                }
                return _people;
            }
        }
  

        void IRepositoryWrapper.Save()
        {
            _repoContext.SaveChanges();
        }
    }
}