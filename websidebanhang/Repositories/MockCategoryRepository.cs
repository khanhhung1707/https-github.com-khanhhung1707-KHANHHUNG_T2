﻿using websidebanhang.Models;

namespace websidebanhang.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categoryList;
        public MockCategoryRepository()
        {
            _categoryList = new List<Category>
        {
        new Category { ID = 1, Name = "Laptop" },
        new Category { ID = 2, Name = "Desktop" },
        // Thêm các category khác
        };
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryList;
        }
    }
}