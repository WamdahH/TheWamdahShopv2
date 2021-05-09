using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWamdahShop.Models;

namespace TheWamdahShop.Interfaces
{
    public interface IAddPerson
    {
        public Title Title { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

