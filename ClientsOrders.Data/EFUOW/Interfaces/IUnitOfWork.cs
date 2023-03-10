using ClientsOrders.Data.EFUOW.Entities;
using ClientsOrders.Data.EFUOW.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsOrders.Data.EFUOW.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get;}
        IOrderRepository Orders { get; }

        void Save();
    }
}
