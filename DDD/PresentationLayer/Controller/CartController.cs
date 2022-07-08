using System;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controller
{
    [Produces("application/json")]
    [Route("api/Cart")]
    public class CartController : ApiController
    {
        public CartController()
        {
            
        }

        [HttpGet("customer")]
        public IActionResult GetByCustomerId(Guid customerId)
        {
            return Ok("GetByCustomerId");
        }

        [HttpPost("add")]
        public IActionResult AddToCart()
        {
            return Ok("AddToCart");
        }

        [HttpPost("remove")]
        public IActionResult RemoveProductFromCart()
        {
            return Ok("RemoveProductFromCart");
        }

        [HttpGet("checkout")]
        public IActionResult Checkout(Guid customerId)
        {
            return Ok("Checkout");
        }
    }
}