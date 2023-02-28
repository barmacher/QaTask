using ClientsOrders.Data.EFUOW.EF;
using ClientsOrders.Data.EFUOW.Entities;
using ClientsOrders.Data.EFUOW.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsOrders.Data.EFUOW.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private ClientsOrdersContext db;
        private IClientRepository _clientsRepository;
        private IRepository<Order> _ordersRepository;

        public EFUnitOfWork()
        {
            db = new ClientsOrdersContext();
        }
        public IClientRepository Clients
        {
            get
            {
                if (_clientsRepository == null)
                {
                    _clientsRepository = new ClientsRepository(db);
                }
                return _clientsRepository;
            }
        }
        public IRepository<Order> Orders
        {
            get
            {
                if (_ordersRepository == null)
                {
                    _ordersRepository = new OrdersRepository(db);
                }
                return _ordersRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if(disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
       
    }
}
