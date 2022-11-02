﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        public List<Order> ReadAll();
        //public int Create(Order member);
        //public int Update(int OrderId, Order order);
        //public int Delete(Order member);
    }
}
