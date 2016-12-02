using System;
using System.Collections.Generic;

namespace Inventory.Models
{
    public interface IProductRepository
    {
        IEnumerable<ProductDTO> GetAll();
        ProductDTO Get(Guid id);
        void Add(ProductDTO product);
        void Update(ProductDTO product);
        ProductDTO Remove(Guid id);
    }
}