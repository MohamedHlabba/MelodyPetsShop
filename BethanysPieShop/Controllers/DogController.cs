using MelodysZooShop.Models;
using MelodysZooShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MelodysZooShop.Controllers
{
    public class DogController : Controller
    {
        private readonly IDogRepository _dogRepository;
        private readonly ICategoryRepository _categoryRepository;
        public DogController(IDogRepository dogRepository, ICategoryRepository categoryRepository)
        {
            _dogRepository = dogRepository;
            _categoryRepository = categoryRepository;

        }
        public ViewResult List()
        {
            DogsListViewModel dogsListViewModel = new DogsListViewModel();
            dogsListViewModel.Dogs = _dogRepository.AllDogs;
            dogsListViewModel.CurrrentCategory = "Toy Dogs";
            return View(dogsListViewModel);
        }
        public IActionResult Details(int id)
        {
            var dog = _dogRepository.GetDogById(id);
            if (dog == null)
            {
                return NotFound();

            }
            return View(dog);
        }
    }
}
