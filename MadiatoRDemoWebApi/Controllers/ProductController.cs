using MadiatoRDemoWebApi.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MadiatoRDemoWebApi.Models.QueryModels.ProductQueries;

namespace MadiatoRDemoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        [HttpGet("GetProductList")]
        public async Task<ActionResult> GetProducts()
        {
            var products = await Mediator.Send(new GetProductsQuery());
            return Ok(products);
        }
        [HttpGet("{Id:int}", Name = "GetProductById")]
        public async Task<ActionResult> GetProduct(int Id)
        {
            var product = await Mediator.Send(new GetProductByIdQuery(Id));
            return Ok(product);
        }
        [HttpPost("AddProduct")]
        public async Task<ActionResult> AddProduct([FromBody] Product product)
        {
            await Mediator.Send(new AddProductCommand(product));
            return StatusCode(200);
        }
    }
}
