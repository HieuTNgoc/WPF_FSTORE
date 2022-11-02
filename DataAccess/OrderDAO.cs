using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        private Asm1PRNContext _Context;

        public OrderDAO()
        {
            _Context = DataProvider.Ins.DB;
        }

        public List<Order> getAll()
        {
            return _Context.Orders.ToList();
        }
    }
}
