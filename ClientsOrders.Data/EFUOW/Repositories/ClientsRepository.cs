﻿using ClientsOrders.Data.EFUOW.EF;
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
    public class ClientsRepository : IClientRepository
    {
        private ClientsOrdersContext db;

        public ClientsRepository()
        {
        }

        public ClientsRepository(ClientsOrdersContext context)
        {
            this.db = context;
        }
        public void Add(Client item)
        {
            db.clients.Add(item);
        }

       
        public void Delete(int id)
        {
            Client client = db.clients.FirstOrDefault(x => x.ID == id);
            db.clients.Remove(client);
        }

        public IEnumerable<Client> GetAll()
        {
            return db.clients;
        }

        public void Update(Client item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public Client GetClientById(int id)
        {
            Client client = db.clients.FirstOrDefault(client => client.ID == id);
            return client;
        }

      
    }
}
