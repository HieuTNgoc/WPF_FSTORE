using BusinessObject;
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
        public int ProductCount(string productName);
        public void Create(Product product);

        public void Update(int productId, Product product);
        //public int Create(Product member);
        //public int Delete(Product member);
    }
}
