using JNCollection.Website.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JNCollection.Website.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IClotheRepository _clotheRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IClotheRepository clotheRepository, ShoppingCart shoppingCart)
        {
            _clotheRepository = clotheRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItem();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int clotheId)
        {
            var selectedClothe = _clotheRepository.AllClothes.FirstOrDefault(p => p.ClotheId == clotheId);

            if (selectedClothe != null)
            {
                _shoppingCart.AddToCart(selectedClothe, 1);
            }
            return RedirectToAction("Index");
        }
    }
}
