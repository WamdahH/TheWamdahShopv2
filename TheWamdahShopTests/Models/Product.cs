using System;

namespace TheWamdahShop.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string PictureURL { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Person Person { get; set; }
    }
}
