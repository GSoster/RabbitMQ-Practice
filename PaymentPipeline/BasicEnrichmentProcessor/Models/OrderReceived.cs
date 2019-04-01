using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEnrichmentProcessor.Models
{
    class OrderReceived
    {
        public Guid Id { get; set; }
        public decimal TotalValue { get; set; }
    }
}
