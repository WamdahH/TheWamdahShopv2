using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWamdahShop.Interfaces
{
    public interface IRepositoryWrapper
    {
        IPersonRepository People { get; }
        IProductRepository Products { get; }
        void Save();
    }
}
