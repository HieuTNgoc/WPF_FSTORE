using BusinessObject;

using DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using SalesWPFApp.ViewModels;
using DataAccess.Repository;

namespace SalesWPFApp.ViewModels
{
    public class OrderViewModel:BaseViewModel
    {
        private IProductRepository _ProductRepository = new ProductRepository();
        private IEnumerable<Product> _ProductList;
        public IEnumerable<Product> ProductList { get => _ProductList; set { _ProductList = value; OnPropertyChanged(); } }
        private string _ProductName;
        public string ProductName { get => _ProductName; set { _ProductName = value; OnPropertyChanged(); } }

        private int _CategoryId;
        public int CategoryId { get => _CategoryId; set { _CategoryId = value; OnPropertyChanged(); } }

        private string _Weight;
        public string Weight { get => _Weight; set { _Weight = value; OnPropertyChanged(); } }

        private decimal _UnitPrice;
        public decimal UnitPrice { get => _UnitPrice; set { _UnitPrice = value; OnPropertyChanged(); } }

        private int _UnitStock;
        public int UnitStock { get => _UnitStock; set { _UnitStock = value; OnPropertyChanged(); } }

        private Product _SelectedProduct;
        public Product SelectedProduct
        {
            get => _SelectedProduct;
            set
            {
                _SelectedProduct = value;
                OnPropertyChanged();
                //if (SelectedProduct != null)
                //{
                //    ProductName = SelectedProduct.ProductName;
                //    CategoryId = SelectedProduct.CategoryId;
                //    Weight = SelectedProduct.Weight;
                //    UnitPrice = SelectedProduct.UnitPrice;
                //    UnitStock = SelectedProduct.UnitStock;
                //}
            }
        }


        private IOrderRepository _OrderRepository = new OrderRepository();

        private IEnumerable<Order> _OrderList;
        public IEnumerable<Order> OrderList { get => _OrderList; set { _OrderList = value; OnPropertyChanged(); } }

        private Product _SelectedOrder;
        public Product SelectedOrder
        {
            get => _SelectedOrder;
            set
            {
                _SelectedOrder = value;
                OnPropertyChanged();
                //if (SelectedProduct != null)
                //{
                //    ProductName = SelectedProduct.ProductName;
                //    CategoryId = SelectedProduct.CategoryId;
                //    Weight = SelectedProduct.Weight;
                //    UnitPrice = SelectedProduct.UnitPrice;
                //    UnitStock = SelectedProduct.UnitStock;
                //}
            }
        }

        private IOrderDetailRepository _OrderDetailRepository = new OrderDetailRepository();

        private IEnumerable<OrderDetail> _OrderDetailList;
        public IEnumerable<OrderDetail> OrderDetailList { get => _OrderDetailList; set { _OrderDetailList = value; OnPropertyChanged(); } }

        private Product _SelectedOrderDetail;
        public Product SelectedOrderDetail
        {
            get => _SelectedOrderDetail;
            set
            {
                _SelectedOrderDetail = value;
                OnPropertyChanged();
                //if (SelectedProduct != null)
                //{
                //    ProductName = SelectedProduct.ProductName;
                //    CategoryId = SelectedProduct.CategoryId;
                //    Weight = SelectedProduct.Weight;
                //    UnitPrice = SelectedProduct.UnitPrice;
                //    UnitStock = SelectedProduct.UnitStock;
                //}
            }
        }

        public OrderViewModel()
        {
            LoadListData();
        }

         void LoadListData()
        {
            OrderList = _OrderRepository.ReadAll();
            OrderDetailList = _OrderDetailRepository.ReadAll();
            ProductList = _ProductRepository.ReadAll();
        }
    }
}
