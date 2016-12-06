using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        public ProductController(IProductRepository productRepo)
        {
            this.ProductRepo = productRepo;
        }

        public IProductRepository ProductRepo { get; set; }

        // GET api/product
        [HttpGet]
        public IEnumerable<ProductDTO> Get()
        {
            return this.ProductRepo.GetAll();
        }

        [HttpGet("{id}", Name = "Get Product By Id")]
        public ProductDTO GetById(Guid id)
        {
            return this.ProductRepo.Get(id);
        }

        [HttpPost]
        public ProductDTO Post([FromBody] ProductDTO product)
        {
            var productDTOResult = this.ProductRepo.Add(product);
            return productDTOResult;
        }

        [HttpPut]
        public ProductDTO Update([FromBody] ProductDTO product)
        {
            var productDTOResult = this.ProductRepo.Update(product);
            return productDTOResult;
        }

        [HttpGet("search")]
        public IEnumerable<ProductDTO> Get(string name)
        {
            return this.ProductRepo.GetByName(name);
        }
    }
}