using System;
using System.Collections.Generic;
using System.Text;
using OrderConsumer.Model;
using System.Threading.Tasks;

namespace OrderConsumer.Repositories
{
    interface IRepository
    {
        Task<CreatedOrder> GetAsync(Guid id);
        Task Save(CreatedOrder model);
    }
}
