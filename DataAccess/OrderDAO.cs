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
        IOrderRepository OrderRepository;

        public OrderDAO(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }

        // > 0 asc ; < 0 desc
        public List<Order> reportSalesByDate(DateTime startDate, DateTime endDate, int orderBy)
        {
            return null;
        }
        public int delete(Order order)
        {
            return OrderRepository.Delete(order);
        }
        public int update(int id, Order order)
        {
            return OrderRepository.Update(id,order);
        }
        public List<Order> getAll()
        {
            return OrderRepository.ReadAll();
        }
        public int add(Order order)
        {
            return OrderRepository.Create(order);   
        }
    }
}
