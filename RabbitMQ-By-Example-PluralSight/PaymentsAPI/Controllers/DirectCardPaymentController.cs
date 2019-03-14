using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentsAPI.Models;

namespace PaymentsAPI.Controllers
{
    public class DirectCardPaymentController : ControllerBase
    {
        [HttpGet]
        public IHttpActionResult MakePayment(CardPayment cardPayment)
        {
            return Ok(cardPayment);
        }
    }

}
