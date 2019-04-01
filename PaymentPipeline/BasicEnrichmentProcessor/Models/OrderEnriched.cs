using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEnrichmentProcessor.Models
{
    class OrderEnriched : OrderReceived
    {
        public string EnrichedField1 { get; set; }
        public string EnrichedField2 { get; set; }
        public string EnrichedField3 { get; set; }
    }
}
