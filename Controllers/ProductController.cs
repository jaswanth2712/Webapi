using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapi.Models;

namespace Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

      static  List<Product> products = new List<Product>() {
    new Product ( ) { Id =1 , ProductName = " Shakib " , Amount = 1001 } ,
    new Product ( ) { Id = 2 , ProductName = " Rabbi " , Amount = 1002 } ,
    new Product ( ) { Id = 3 , ProductName = " Rohit " , Amount = 1003 } ,
    new Product ( ) { Id = 4 , ProductName = " Musgfiq " , Amount = 1004 } ,
};
        [HttpGet]

        public IActionResult Gets()
        {

            if (products.Count == 0)
            {
                return NotFound(" No list found . ");
            }
            return Ok(products);
        }
        [HttpGet("getstudent")]
        public IActionResult Get(int id)
        {
            var product=products.SingleOrDefault(x=>x.Id == id);
            if (products.Count == null)
            {
                return NotFound(" No list found . ");
            }
            return Ok(products);
        }
        [HttpPost]

        public IActionResult Save(Product product)
        {
            products.Add(product);
            if (products.Count == 0)
            {
                return NotFound(" No list found . ");
            }
            return Ok(products);

        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = products.SingleOrDefault(x => x.Id == id);
            if (products == null)
            {
                return NotFound(" No student found . ");
            }
            products.Remove(product);
            if (products.Count == 0)
            {
                return NotFound(" No list found . ");
            }
            return Ok(products);

        }


    }
}