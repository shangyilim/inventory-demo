using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

namespace Inventory.Models
{
    public class ProductRepository : IProductRepository
    {
        private InventoryContext _inventoryContext;
        private readonly IMapper _mapper;

        public ProductRepository(InventoryContext InventoryContext, IMapper mapper)
        {
            this._inventoryContext = InventoryContext;
            this._mapper = mapper;
        }

        public ProductDTO Get(Guid id)
        {
            var product = this._inventoryContext.Products.Where(p => p.Id == id).FirstOrDefault();
            ProductDTO productDTO = mapDTO(product);

            return productDTO;
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            List<Product> productList = this._inventoryContext.Products.ToList();
            List<ProductDTO> productDTOList = new List<ProductDTO>();

            foreach (var product in productList)
            {
                productDTOList.Add(mapDTO(product));
            }

            return productDTOList;
        }

        public IEnumerable<ProductDTO> GetByName(String searchString)
        {
            List<Product> productList = this._inventoryContext.Products.Where(p => p.Name.Contains(searchString)).ToList();
            
            
            List<ProductDTO> productDTOList = new List<ProductDTO>();

            foreach (var product in productList)
            {
                productDTOList.Add(mapDTO(product));
            }

            return productDTOList;
        }

        public ProductDTO Add(ProductDTO productDTO)
        {
            productDTO.Id = Guid.NewGuid();
            //Product product = map(productDTO);
            
            Product product = Mapper.Map<Product>(productDTO);

            this._inventoryContext.Add(product);
            this._inventoryContext.SaveChanges();

            return productDTO;
        }

        public ProductDTO Update(ProductDTO productDTO)
        {
            Product productFound = this._inventoryContext.Products.Where(p => p.Id == productDTO.Id).FirstOrDefault();

            if(productFound == null) 
            {
                throw new Exception("Product not found.");
            }

            productFound.Name = productDTO.Name;
            productFound.Image = productDTO.Image;
            productFound.costPrice = productDTO.costPrice;  
            productFound.sellingPrice = productDTO.sellingPrice;

            this._inventoryContext.SaveChanges();
            return productDTO;
        }

        public ProductDTO Remove(Guid id)
        {
            throw new NotImplementedException();
        }

       

        // This can be replaced by AutoMapper
        private ProductDTO mapDTO(Product product)
        {
            ProductDTO productDTO = new ProductDTO();
            productDTO.Id = product.Id;
            productDTO.Name = product.Name;
            productDTO.Image = product.Image;
            productDTO.sellingPrice = product.sellingPrice;
            productDTO.costPrice = product.costPrice;

            return productDTO;
        }

        private Product map(ProductDTO productDTO)
        {
            Product product = new Product();
            product.Id = productDTO.Id;
            product.Name = productDTO.Name;
            product.Image = productDTO.Image;
            product.sellingPrice = productDTO.sellingPrice;
            product.costPrice = productDTO.costPrice;

            return product;
        }
    }
}
