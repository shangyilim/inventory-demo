using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Models
{
    public class ProductRepository : IProductRepository
    {
        private ProductContext _productContext;

        public ProductRepository(ProductContext productContext) {
            this._productContext = productContext;
        }

        public void Add(Product product)
        {
            product.Id = Guid.NewGuid();

            this._productContext.Add(product);
            this._productContext.SaveChanges();
        }

        public Product Get(Guid id)
        {
            Product productFound = this._productContext.Products.Where(p => p.Id == id).FirstOrDefault();

            return productFound;
        }

        public IEnumerable<Product> GetAll()
        {
            List<Product> productList = this._productContext.Products.ToList();

            return productList;
        }

        public Product Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
