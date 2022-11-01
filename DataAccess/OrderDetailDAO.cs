using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        IOrderRepository orderRepository;

        public OrderDetailDAO(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        // > 0 asc ; < 0 desc
        public List<OrderDetail> reportSalesByDate(DateTime startDate, DateTime endDate, int orderBy)
        {
            return null;
        }
        public int delete(Order order)
        {
            return orderRepository.Delete(order);
        }
        public int update(int id, Order order)
        {
            return orderRepository.Update(id,order);
        }
        public List<Order> getAll()
        {
            return orderRepository.ReadAll();
        }
        public int add(Order order)
        {
            return orderRepository.Create(order);   
        }
    }
}
