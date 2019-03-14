using System;

namespace PaymentsAPI.Models
{
    public class CardPayment
    {
        public decimal Amount { get; set; }
        public int CardNumber { get; set; }
        public string Name { get; set; }
    }
}