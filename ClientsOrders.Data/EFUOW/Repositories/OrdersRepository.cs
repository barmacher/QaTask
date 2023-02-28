using ClientsOrders.Data.EFUOW.EF;
using ClientsOrders.Data.EFUOW.Entities;
using ClientsOrders.Data.EFUOW.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsOrders.Data.EFUOW.Repositories
{
    public class OrdersRepository : IOrderRepository
    {
        private ClientsOrdersContext db;

        public OrdersRepository(ClientsOrdersContext context)
        {
            this.db = context;
        }
        public void Add(Order item)
        {
            db.orders.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            return db.orders;
        }

        public List<Order> GetUserOrders(int clientId)
        {
            return db.orders.Where(o => o.ClientID == clientId).ToList<Order>();
        }

        public void Update(Order item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

    }
}
