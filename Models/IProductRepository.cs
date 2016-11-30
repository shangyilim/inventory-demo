using System;
using System.Collections.Generic;

namespace Inventory.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(Guid id);
        void Add(Product product);
        void Update(Product product);
        Product Remove(Guid id);
    }
}