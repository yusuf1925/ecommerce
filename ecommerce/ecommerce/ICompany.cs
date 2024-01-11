using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public interface ICompany
    {
        void AddCategory(ICategory categories);
        void GetTopCategoryNameByProductCount();
        void GetTopCategoryBySumOfProductPrices();
        void GetCategoriesWithSumOfTheProductPrices();
    }
}
