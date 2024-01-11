using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{

    public class Category : ICategory
    {
        public Category(int id, string name)
        {
            id = this.Id;
            name = this.Name;
            //initialize Products as an empty list
            

        }
        public int Id { get; set; }
        public string Name { get; set; }

        List<IProduct> products = new List<IProduct>();


        public void AddProduct(IProduct products)
        {
            products = this.products;
            products.Add(new IProduct());
        }

        
    }
}
