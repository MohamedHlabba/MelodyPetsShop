using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelodysZooShop.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsDogOfTheWeek { get; set; }
         public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public string Notes { get; set; }
        public Category Category { get; set; }
    }
}
