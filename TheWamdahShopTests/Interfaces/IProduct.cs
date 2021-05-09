using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWamdahShop.Interfaces
{
    public interface IProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string PictureURL { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
