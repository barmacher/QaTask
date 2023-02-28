using ClientsOrders.Data.Models.Common;

namespace ClientsOrders.Data.EFUOW.Entities
{
    public class Client
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string PhoneNum { get; set; }
        public int OrderAmount { get; set; }
        public DateTime DateAdd { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}