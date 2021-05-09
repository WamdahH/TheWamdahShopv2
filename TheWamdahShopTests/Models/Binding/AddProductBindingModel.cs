using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWamdahShop.Models.Binding
{
    public class AddProductBindingModel
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int PersonID { get; set; }
    }
}
