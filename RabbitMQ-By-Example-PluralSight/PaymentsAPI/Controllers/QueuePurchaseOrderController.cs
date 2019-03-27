using Microsoft.AspNetCore.Mvc;
using PaymentsAPI.Models;
using System.Web.Http;
namespace PaymentsAPI.Controllers
{
    //[RoutePrefix("")]// 
    public class QueuePurchasePaymentController : ControllerBase
    {
        [HttpPost]
        public IActionResult MakePayment([FromBody] PurchaseOrder purchaseOrder)
        {
            return Ok(purchaseOrder);
        }
    }
}