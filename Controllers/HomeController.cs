using JNCollection.Website.Models;
using JNCollection.Website.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JNCollection.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClotheRepository _clotheRepository;

        public HomeController(IClotheRepository clotheRepository)
        {
            _clotheRepository = clotheRepository;
        }
        public IActionResult Index()
        {
            var homeVieModel = new HomeViewModel
            {
                ClotheOfTheWeek = _clotheRepository.ClothesOfTheWeek
            };

            return View(homeVieModel);
        }
    }
}

