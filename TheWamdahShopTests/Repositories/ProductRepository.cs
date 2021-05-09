using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWamdahShop.Data;
using TheWamdahShop.Interfaces;
using TheWamdahShop.Models;

namespace TheWamdahShop.Repositories
{
    public class ProductRepository : Repository<Product>,IProductRepository
    {
        public ProductRepository(AppDbContext dbContext):base(dbContext)
        {

        }
    }
}
