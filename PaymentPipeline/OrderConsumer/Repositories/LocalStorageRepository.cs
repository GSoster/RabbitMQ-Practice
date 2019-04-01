using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OrderConsumer.Model;

namespace OrderConsumer.Repositories
{
    class LocalStorageRepository : IRepository
    {
        public Task<CreatedOrder> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Save(CreatedOrder model)
        {
            throw new NotImplementedException();
        }
    }
}
