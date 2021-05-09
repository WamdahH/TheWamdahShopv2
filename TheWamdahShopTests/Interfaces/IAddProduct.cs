using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWamdahShop.Interfaces
{
    public interface IAddProduct
    {
      
        public string Name { get; set; }
        public float Price { get; set; }
        public string PictureURL { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
