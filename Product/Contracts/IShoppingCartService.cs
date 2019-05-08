using System;
using System.Collections.Generic;
using Product.Domain.Models;

namespace Product.Contracts
{
    public interface IShoppingCartService
    {
        IEnumerable<ProductItem> GetAllItems();
        ProductItem Add(ProductItem newItem);
        ProductItem GetById(long id);
        void Remove(long id);
    }
}
