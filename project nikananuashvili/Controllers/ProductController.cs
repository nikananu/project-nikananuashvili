using Microsoft.AspNetCore.Mvc;
using project.Db;
using project.domain.Models;
using project.services;
using project.services.Abstractions;
using project.services.implementations;

namespace project_nikananuashvili.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public Iproduct _ProductService;

        public ProductController(Iproduct ProductService)
        {
            _ProductService= ProductService  ;
        }
        [HttpGet("GetAllProduct")]
        public async Task<List<Product>> GetAllProduct()
        {
            var GetAllproducts = await _ProductService.GetAllProduct();

            return GetAllproducts;
        }
        [HttpPost("AddProduct")]
        public async Task<Product> AddProduct(Product product)
        {
            var addedCategory= await _ProductService.AddProduct(product);

            return addedCategory;
        }
        [HttpPut("UpdateProduct/{id}")]
        public Product UpdateProduct(int id, Product product)
        {
            var updatedCategory= _ProductService.UpdateProduct(id,product);

            return updatedCategory;
        }
        [HttpDelete("DeleteProduct/{id}")]
        public Product DeleteProduct(int id)
        {
            var DeletedProduct= _ProductService.DeleteProduct(id);

            return DeletedProduct;
        }






    }
}
