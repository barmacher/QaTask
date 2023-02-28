using ClientsOrders.Data.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsOrders.Data.EFUOW.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public void Add(T item); // C
        public IEnumerable<T> GetAll(); // R
        public void Update(T item); // U
        public void Delete(int id); // D
    }
}
