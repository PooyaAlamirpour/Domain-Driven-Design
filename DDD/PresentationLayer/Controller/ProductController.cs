using System;
using System.Net;
using System.Threading.Tasks;
using ApplicationLayer.Models;
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
        public IActionResult AddProduct([FromBody] AddNewProductViewModel model)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(new {IsSuccessStatusCode = false, Errors = ModelState});

                return Ok(new {IsSuccessStatusCode = true});
            }
            catch (Exception ex)
            {
                return NotFound(new { IsSuccessStatusCode = false, Errors = ex.Message });
            }
        }
    }
}