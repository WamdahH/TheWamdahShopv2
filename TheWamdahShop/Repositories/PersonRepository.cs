using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWamdahShop.Data;
using TheWamdahShop.Interfaces;
using TheWamdahShop.Models;

namespace TheWamdahShop.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
