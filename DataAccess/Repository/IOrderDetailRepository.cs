using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public List<OrderDetail> ReadAll();
        //public int Create(OrderDetail OrderDetail);
        //public int Update(int OrderId, int productId, OrderDetail OrderDetail);
        //public int Delete(OrderDetail OrderDetail);
    }
}
