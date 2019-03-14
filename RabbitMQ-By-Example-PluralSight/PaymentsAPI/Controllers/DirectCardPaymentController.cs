using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentsAPI.Models;
using System.Web.Http;

namespace PaymentsAPI.Controllers
{
    public class DirectCardPaymentController : ControllerBase
    {
        [HttpPost]
        public IActionResult MakePayment([FromBody]  CardPayment cardPayment)
        {
            return Ok(cardPayment);
        }
    }

}
