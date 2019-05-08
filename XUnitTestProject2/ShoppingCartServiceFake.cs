using System;
using System.Collections.Generic;
using System.Linq;
using Product.Contracts;
using Product.Domain.Models;

namespace Products_tests
{
    class ShoppingCartServiceFake : IShoppingCartService
    {
        private readonly List<ProductItem> _shoppingCart;

        public ShoppingCartServiceFake()
        {
            _shoppingCart = new List<ProductItem>()
            {
                new ProductItem() { Id = 1,
                    Name = "Orange Juice", Manufacturer="Orange Tree", Price = "100" },
                new ProductItem() { Id = 2 ,
                    Name = "Diary Milk", Manufacturer="Mad Cow", Price = "100"},
                new ProductItem() { Id = 3,
                    Name = "Frozen Pizza", Manufacturer="Uncle Mickey's", Price = "300" }
            };
        }

        public IEnumerable<ProductItem> GetAllItems()
        {
            return _shoppingCart;
        }

        public ProductItem Add(ProductItem newItem)
        {
            //newItem.Id = long.NewGuid();
            _shoppingCart.Add(newItem);
            return newItem;
        }

        public ProductItem GetById(long id)
        {
            return _shoppingCart.Where(a => a.Id == id)
                .FirstOrDefault();
        }

        public void Remove(long id)
        {
            var existing = _shoppingCart.First(a => a.Id == id);
            _shoppingCart.Remove(existing);
        }
    }
}
