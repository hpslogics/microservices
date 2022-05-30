using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ProductContext _productContext;

        public ProductController(ProductContext productContext, ILogger<ProductController> logger)
        {
            _productContext = productContext;
            _logger = logger;
        }

        private readonly ILogger<ProductController> _logger;



        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productContext.Products.Find(p => true).ToListAsync();

        }
    }
}
