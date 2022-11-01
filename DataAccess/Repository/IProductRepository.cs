﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public List<Product> ReadAll();
        //public int Create(Product member);
        //public int Update(int ProductId, Product member);
        //public int Delete(Product member);
    }
}