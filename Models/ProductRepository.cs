using System;
using System.Collections.Generic;

namespace Inventory.Models
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository()
        {
            this.ProductList = new List<Product>();
            this.GenerateData();
        }

        private List<Product> ProductList;

        public void Add(Product product)
        {
            product.Id = Guid.NewGuid();
            this.ProductList.Add(product);
        }

        public Product Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return this.ProductList;
        }

        public Product Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        private void GenerateData()
        {
            Product productA = new Product();
            productA.Id = Guid.NewGuid();
            productA.Name = "Coke";
            productA.Description = "This is a coke";
            productA.sellingPrice = 10;
            productA.costPrice = 1;

            this.ProductList.Add(productA);
        }
    }
}
