using System;

namespace PaymentsAPI.Models
{
    public class PurchaseOrder
    {
        public decimal AmountToPlay { get; set; }
        public string PoNumber { get; set; }
        public string  CompanyName { get; set; }
        public int PaymentDayTerms { get; set; }
    }
}