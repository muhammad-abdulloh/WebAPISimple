using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPISimple.Models;
using WebAPISimple.Repositoy;

namespace WebAPISimple.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        static readonly IProductRepository repository = new ProductRepository();

        [HttpGet]
        public async ValueTask<IEnumerable<Product>> GetAllProducts()
        {
            return await repository.GetAllAsync();
        }

        [HttpPost]
        public Product AddProduct (Product product)
        {
            var productItem = repository.Add(product);

            return productItem;
        }
    }
}
