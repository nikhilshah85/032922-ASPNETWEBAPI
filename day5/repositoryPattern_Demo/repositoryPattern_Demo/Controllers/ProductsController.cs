using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using repositoryPattern_Demo;
using repositoryPattern_Demo.Models.Repository;
namespace repositoryPattern_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors()] //default policy gets applied here
    public class ProductsController : ControllerBase
    {
        //so far controller use to deal with source directly

        IProductRepository _productRepository;

        public ProductsController(IProductRepository productrepoObj)
        {
            _productRepository = productrepoObj;
        }

        [HttpGet]
        [Route("plist")]
        public IActionResult GetProductList()
        {
            return Ok(_productRepository.GetAllProducts());
        }

        [HttpGet]
        [Route("offer")]
        public IActionResult Getoffer()
        {
            return Ok(_productRepository.getOffer());
        }




    }
}
