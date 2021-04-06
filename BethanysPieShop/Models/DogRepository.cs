using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelodysZooShop.Models
{
    public class DogRepository : IDogRepository
    {

        private readonly AppDbContext db;
        public DogRepository(AppDbContext appDbContext)
        {
            db = appDbContext;

        }
        public IEnumerable<Dog> AllDogs
        {
            get
            {
                return db.Dogs.Include(c=>c.Category);
            }
        }
        public IEnumerable<Dog> DogsOfTheWeek
        {
            get
            {
                return db.Dogs.Include(c => c.Category).Where(c => c.IsDogOfTheWeek);
            }
        }
        public Dog GetDogById(int dogId)
        {
            return db.Dogs.FirstOrDefault(p => p.DogId == dogId);
        }
    }
}
