using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Upsert.Entities;
using Upsert.Interfaces;

namespace Upsert.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet("{productId}")]
        public Product Get(int productId)
        {
            return _productService.GetProduct(productId);        
        }

        [HttpPut]
        public Product Put([FromBody] Product products)
        {
            return _productService.SaveProduct(products);        
        }
    }
}
