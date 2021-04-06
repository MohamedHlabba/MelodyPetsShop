using MelodysZooShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelodysZooShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Dog>  DogsOfTheWeek{ get; set; }

    }
}
