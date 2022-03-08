using JNCollection.Website.Models;
using JNCollection.Website.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JNCollection.Website.Controllers
{
    public class ClotheController : Controller
    {
        private readonly IClotheRepository _clothesRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ClotheController(IClotheRepository clothesRepository, ICategoryRepository categoryRepository)
        {
            _clothesRepository = clothesRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            ClotheListViewModel clotheListViewModel = new ClotheListViewModel();
            clotheListViewModel.clothes = _clothesRepository.AllClothes;

            clotheListViewModel.CurrentCategory = "Man wear";
            return View(clotheListViewModel);
        }

        public IActionResult Details(int id)
        {
            var clothe = _clothesRepository.GetClotheById(id);
            if (clothe == null)
                return NotFound();
            return View(clothe);
        }
    }
}
