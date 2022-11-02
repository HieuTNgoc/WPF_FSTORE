using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private OrderDetailDAO _OrderDetailDAO;

        public OrderDetailRepository()
        {
            _OrderDetailDAO = new OrderDetailDAO();
        }

        public List<OrderDetail> ReadAll()
        {
            return _OrderDetailDAO.getAll();
        }
    }
}
