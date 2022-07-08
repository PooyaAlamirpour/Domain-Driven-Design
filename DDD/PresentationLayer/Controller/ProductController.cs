using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controller
{
    public class ProductController : ApiController
    {
        public ProductController()
        {
            
        }

        [HttpGet("id")]
        public IActionResult GetProductById(Guid productId)
        {
            return Ok("GetProductById");
        }

        [HttpPost("Add")]
        public IActionResult AddProduct()
        {
            return Ok("AddProduct");
        }
    }
}