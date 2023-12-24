using project.domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.services.Abstractions
{
    public interface Iproduct
    {
        public Task<List<Product>> GetAllProduct();
        public Task<Product> AddProduct(Product product);
        public Product UpdateProduct(int id, Product book);
        public Product DeleteProduct(int id);
    }
}

