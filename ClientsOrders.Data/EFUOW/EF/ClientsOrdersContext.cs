using ClientsOrders.Data.EFUOW.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClientsOrders.Data.EFUOW.EF
{
    public class ClientsOrdersContext : DbContext
    {
            public DbSet<Client> clients { get; set; }
            public DbSet<Order> orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            string? str1 = config["ConnectionString"];
            string? str2 = config
                .GetSection("ConnectionStrings")
                ["ConnectionString"];

            string? connectionString = config
                .GetConnectionString("ConnectionString");

            optionsBuilder
                .UseSqlServer(connectionString);
        }

        //protected override void OnModel
    }
    }



