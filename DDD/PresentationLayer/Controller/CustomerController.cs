using System;
using System.Net;
using System.Threading.Tasks;
using DomainLayer.Core.Notification;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controller
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : ApiController
    {
        public CustomerController(INotificationHandler<DomainNotification> notificationHandler) : base(notificationHandler)
        {
            
        }
        
        /// <summary>
        /// Checking the customer email if it is available.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Employee
        ///     {        
        ///       "firstName": "Mike",
        ///       "lastName": "Andrew",
        ///       "emailId": "Mike.Andrew@gmail.com"        
        ///     }
        /// </remarks>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpGet("email")]
        public IActionResult IsEmailAvailable(string email)
        {
            return Ok("IsEmailAvailable");
        }

        [HttpGet("id")]
        public IActionResult GetCustomerById(Guid customerId)
        {
            return Ok("GetCustomerById");
        }

        [HttpGet("purchases")]
        public IActionResult GetPurchasesHistory(Guid customerId)
        {
            return Ok("GetPurchasesHistory");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Customer is added successfully</response>
        [HttpPost("add")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> AddCustomer()
        {
            return Ok("AddCustomer");
        }
        
        [HttpPost("delete")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> DeleteCustomer()
        {
            return Ok("DeleteCustomer");
        }
    }
}