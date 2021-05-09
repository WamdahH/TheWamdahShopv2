using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWamdahShop.Models
{
    public class Person
    {
        public int ID { get; set; }
        public Title Title { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public virtual List<Product> Products { get; set; }
    }
}
