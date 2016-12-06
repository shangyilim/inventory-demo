using System;
using System.Collections.Generic;

namespace Inventory.Models
{
    public interface IProductRepository
    {
        IEnumerable<ProductDTO> GetAll();
        IEnumerable<ProductDTO> GetByName(String searchString);
        ProductDTO Get(Guid id);
        void Add(ProductDTO product);
        void Update(ProductDTO product);
        ProductDTO Remove(Guid id);
    }
}