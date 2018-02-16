using BeverageAndDrink.Data.Interfaces;
using BeverageAndDrink.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BeverageAndDrink.Controllers
{
    public class DrinkController:Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;
            
        }

        public ViewResult List()
        {
            ViewBag.Name = "DotNet, How?";
            DrinkListViewModel vm = new DrinkListViewModel();
            vm.Drinks = _drinkRepository.Drinks;
            vm.CurrentCategory = "DrinkCategory";

            return View(vm); 
        }
    }
}
