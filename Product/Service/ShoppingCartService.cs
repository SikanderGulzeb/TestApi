using System;
using System.Collections.Generic;
using Product.Contracts;
using Product.Domain.Models;

namespace Product.Sevices
{
    public class ShoppingCartService : IShoppingCartService
    {
        public ProductItem Add(ProductItem newItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductItem> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public ProductItem GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Remove(long id)
        {
            throw new NotImplementedException();
        }
    }
}
