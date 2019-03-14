using Microsoft.AspNetCore.Mvc;
using PaymentsAPI.Models;

namespace PaymentsAPI.Controllers
{
    public class QueuePurchasePaymentController : ControllerBase
    {
        [HttpGet]
        public IHttpActionResult MakePayment(PurchaseOrder purchaseOrder)
        {
            return Ok(purchaseOrder);
        }
    }
}