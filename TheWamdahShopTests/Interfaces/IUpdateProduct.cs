using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWamdahShop.Interfaces
{
    public interface IUpdateProduct
    {
  

        public string Name
        {
            get; set;
        }
        public float Price
        {
            get; set;
        }
        public string PictureURL
        {
            get; set;
        }


    }
}
