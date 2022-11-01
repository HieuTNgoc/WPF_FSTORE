using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private Asm1PRNContext _Context;

        public ProductDAO()
        {
            _Context = DataProvider.Ins.DB;
        }

        public List<Product> getAll()
        {
            return _Context.Products.ToList();
        }

        public int countProduct(string productName)
        {
            return _Context.Products.Where(x => x.ProductName == productName).Count();
        }

        public void addNew(Product product)
        {
            try
            {
                _Context.Products.Add(product);
                _Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public List<Product> searchProductByID(int id)
        //{
        //    return null;
        //}
        //public List<Product> searchProductByName(string id)
        //{
        //    return null;
        //}
        //public List<Product> searchProductByUnitPrice(decimal price)
        //{
        //    return null;
        //}
        //public List<Product> searchProductByUnitInStock(int UnitInStock)
        //{
        //    return null;
        //}

        //public int delete(Product Product)
        //{
        //    return ProductRepository.Delete(Product);
        //}
        //public int update(int id, Product Product)
        //{
        //    return ProductRepository.Update(id, Product);
        //}

        //public int add(Product Product)
        //{
        //    return ProductRepository.Create(Product);
        //}
    }
}
