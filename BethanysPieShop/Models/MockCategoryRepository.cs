using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelodysZooShop.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Gun dog.", Description="All-Guns dogs"},
                new Category{CategoryId=2, CategoryName="Toy dog", Description="Cutest dogs ever"},
                new Category{CategoryId=3, CategoryName="Terrier", Description="Get discover the legend dog"}
            };
    }
}
//Gun dog. ...
//Toy dog. ...
//Utility dog. ...
//Hound dog. ...
//Terrier. ...
//Working dog.