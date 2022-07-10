using System;
using System.Linq;
using ApplicationLayer.Models;
using ApplicationLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controller
{
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("id")]
        public IActionResult GetProductById(Guid productId)
        {
            return Ok("GetProductById");
        }

        [HttpPost("Add")]
        public IActionResult AddProduct([FromBody] AddNewProductViewModel model)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(new {IsSuccessStatusCode = false, Errors = ModelState});

                _productService.Add(model);
                
                if(Errors.Any()) return BadRequest(new { IsSuccessStatusCode = false, Errors });
                return Ok(new {IsSuccessStatusCode = true});
            }
            catch (Exception ex)
            {
                return NotFound(new { IsSuccessStatusCode = false, Errors = ex.Message });
            }
        }
    }
}