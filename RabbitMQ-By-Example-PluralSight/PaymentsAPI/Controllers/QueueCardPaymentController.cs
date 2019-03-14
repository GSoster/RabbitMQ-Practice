using Microsoft.AspNetCore.Mvc;
using PaymentsAPI.Models;
using System.Web.Http;
namespace PaymentsAPI.Controllers
{
    public class QueueCardPaymentController : ControllerBase
    {
        [HttpPost]
        public IActionResult MakePayment([FromBody] CardPayment cardPayment)
        {
            return Ok(cardPayment);
        }
    }
}