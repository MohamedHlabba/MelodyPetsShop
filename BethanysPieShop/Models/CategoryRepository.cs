using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelodysZooShop.Models
{
    public class CategoryRepository :ICategoryRepository
    {
        private readonly AppDbContext db;
        public CategoryRepository(AppDbContext appDbContext)
        {
            db = appDbContext;
                
        }

        public IEnumerable<Category> AllCategories => db.Categories;
    }
}
