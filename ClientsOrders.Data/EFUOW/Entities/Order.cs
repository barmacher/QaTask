using ClientsOrders.Data.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsOrders.Data.EFUOW.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int ClientID { get; set; }
        public string Description { get; set; }
        public float OrderPrice { get; set; }
        public DateTime? CloseDate { get; set; }
        public Client Client { get; set; }
    }
}
