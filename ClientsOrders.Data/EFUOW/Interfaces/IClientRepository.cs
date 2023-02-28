using ClientsOrders.Data.EFUOW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsOrders.Data.EFUOW.Interfaces
{
    public interface IClientRepository:IRepository<Client>
    {
        public Client GetClientById(int id);


        
    }
}
