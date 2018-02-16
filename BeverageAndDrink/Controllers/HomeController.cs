﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeverageAndDrink.Data.Interfaces;
using BeverageAndDrink.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeverageAndDrink.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;

        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        // GET: /<controller>/
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredDrinks = _drinkRepository.PreferredDrinks
            };

            return View(homeViewModel);
        }
    }
}
