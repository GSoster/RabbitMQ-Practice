using System;
using System.Collections.Generic;
using System.Text;

namespace OrderConsumer.Model
{
    public class CreatedOrder
    {
        public Guid Id { get; set; }
        public decimal TotalValue { get; set; }

    }
}
