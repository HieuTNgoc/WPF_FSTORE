using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private OrderDAO _OrderDAO;

        public OrderRepository()
        {
            _OrderDAO = new OrderDAO();
        }

        public List<Order> ReadAll()
        {
            return _OrderDAO.getAll();
        }
    }
}
