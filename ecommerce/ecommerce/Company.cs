using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Company:ICompany
    {
        public Company(int id, string name) {

            id = this.Id;
            name = this.Name;
            //initializes the categories property as an empty litst
        }
        public int Id { get; set; }
        public string Name { get; set; }

        List<ICategory> categories = new List<ICategory>();

        public void AddCategory(ICategory categories)
        {
            throw new NotImplementedException();
        }

        public void GetTopCategoryNameByProductCount()
        {
            throw new NotImplementedException();
        }

        public void GetTopCategoryBySumOfProductPrices()
        {
            throw new NotImplementedException();
        }

        public void GetCategoriesWithSumOfTheProductPrices()
        {
            throw new NotImplementedException();
        }
    }
}
