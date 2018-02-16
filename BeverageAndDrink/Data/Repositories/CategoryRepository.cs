using BeverageAndDrink.Data.Interfaces;
using System;
using System.Collections.Generic;
using BeverageAndDrink.Data.Models;

namespace BeverageAndDrink.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;

        IEnumerable<Category> ICategoryRepository.Categories => throw new NotImplementedException();
    }
}
