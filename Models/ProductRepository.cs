using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> ProductList;

        public void Add(Product product)
        {
            product.Id = Guid.NewGuid();

            using(var context = new ProductContext())
            {
                context.Products.Add(product);
            }
        }

        public Product Get(Guid id)
        {
            Product productFound = null;

            using(var context = new ProductContext())
            {
                productFound = context.Products.Where(p => p.Id == id).FirstOrDefault();
            }

            return productFound;
        }

        public IEnumerable<Product> GetAll()
        {
            List<Product> productList = null; 

            using(var context = new ProductContext())
            {
                productList = context.Products.ToList();
            }

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
