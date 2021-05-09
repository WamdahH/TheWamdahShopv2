using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWamdahShop.Models.Binding
{
    public class AddPersonBindingModel
    {
        public Title Title { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
