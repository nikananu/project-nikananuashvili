using Microsoft.EntityFrameworkCore;
using project.Db;
using project.domain.Models;
using project.services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.services.implementations
{
    public class ProductService : Iproduct
    {
        public AppDbContext _appDbContext;

        public ProductService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Product>> GetAllProduct()
        {
            var products = await _appDbContext.Products.ToListAsync();

            return products;
        }

        public async Task<Product> AddProduct(Product product)
        {
            await _appDbContext.Products.AddAsync(product);
            await _appDbContext.SaveChangesAsync();

            return product;
        }

        public Product UpdateProduct(int id, Product product)
        {
            var productInDb = _appDbContext.Products.FirstOrDefault(x => id == x.Id);

            if (productInDb != null)
            {
                productInDb.Name = product.Name;
                productInDb.Price = product.Price;
            }

            _appDbContext.SaveChangesAsync();

            return productInDb;
        }
        public Product DeleteProduct(int id)
        {
            var productInDb = _appDbContext.Products.FirstOrDefault(x => id == x.Id);

            if (productInDb != null)
            {
                _appDbContext.Products.Remove(productInDb);
            }

            _appDbContext.SaveChangesAsync();

            return productInDb;
        }

        

       
    }


}
