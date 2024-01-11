using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Product:IProduct
    {
        public Product(int id,string name,decimal price)
        {
            id = this.Id;
            name = this.Name;
            price = this.Price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
