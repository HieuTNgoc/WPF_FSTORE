using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ProductDAO _ProductDAO;

        public ProductRepository()
        {
            _ProductDAO = new ProductDAO();
        }

        public void Create(Product product)
        {
            _ProductDAO.addNew(product);
        }

        public int ProductCount(string productName)
        {
            return _ProductDAO.countProduct(productName);
        }

        public List<Product> ReadAll()
        {
            return _ProductDAO.getAll();
        }

        //public int Create(Product Product)
        //{
        //    _context.Add(Product);
        //    return _context.SaveChanges();
        //}

        //public int Delete(Product Product)
        //{
        //    _context.Remove(Product);
        //    return _context.SaveChanges();
        //}



        //public int Update(int id, Product Product)
        //{
        //    Product.ProductId = id;
        //    Product oldProduct = _context.Products.Where(o => o.ProductId == id).FirstOrDefault();
        //    oldProduct.ProductId = id;
        //    oldProduct.CategoryId = Product.CategoryId;
        //    oldProduct.ProductName = Product.ProductName;
        //    oldProduct.Weight = Product.Weight;
        //    oldProduct.UnitPrice = Product.UnitPrice;
        //    oldProduct.UnitStock = Product.UnitStock;
        //    _context.Update(oldProduct);
        //    return _context.SaveChanges();
        //}



    }
}
