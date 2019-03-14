using Microsoft.AspNetCore.Mvc;
using PaymentsAPI.Models;

namespace PaymentsAPI.Controllers
{
    public class QueueCardPaymentController : ControllerBase
    {
        [HttpGet]
        public IHttpActionResult MakePayment(CardPayment cardPayment)
        {
            return Ok(cardPayment);
        }
    }
}