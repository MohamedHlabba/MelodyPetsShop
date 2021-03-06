using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelodysZooShop.Models
{
    public interface IDogRepository
    {
        IEnumerable<Dog> AllDogs { get; }
        IEnumerable<Dog> DogsOfTheWeek { get; }
        Dog GetDogById(int dogId);
    }
}
