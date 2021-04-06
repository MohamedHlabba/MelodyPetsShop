using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MelodysZooShop.Models;
using MelodysZooShop.ViewModels;

namespace MelodysZooShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IDogRepository _dogRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDogRepository dogRepository, ShoppingCart shoppingCart)
        {
            _dogRepository = dogRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

        return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int dogId)
        {
            var selectDog = _dogRepository.AllDogs.FirstOrDefault(d => d.DogId == dogId);
            if (selectDog!=null)
            {
                _shoppingCart.AddToCart(selectDog, 1);
            }
            return RedirectToAction("Index");

        }
        public RedirectToActionResult RemoveFromShoppingCart(int dogId)
        {
            var selectDog = _dogRepository.AllDogs.FirstOrDefault(d => d.DogId == dogId);
            if (selectDog != null)
            {
                _shoppingCart.RemoveFromCart(selectDog);
            }
            return RedirectToAction("Index");

        }
    }
}
