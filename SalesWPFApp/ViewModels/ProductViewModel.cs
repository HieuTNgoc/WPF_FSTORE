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
    public class ProductViewModel:BaseViewModel
    {
        private IProductRepository _ProductRepository = new ProductRepository();
        private IEnumerable<Product> _ProductList;
        public IEnumerable<Product> ProductList { get=> _ProductList; set { _ProductList = value; OnPropertyChanged(); } }

        private Product _SelectedProduct;
        public Product SelectedProduct
        {
            get => _SelectedProduct;
            set
            {
                _SelectedProduct = value;
                OnPropertyChanged();
                if (SelectedProduct != null)
                {
                    ProductName = SelectedProduct.ProductName;
                    CategoryId = SelectedProduct.CategoryId;
                    Weight = SelectedProduct.Weight;
                    UnitPrice = SelectedProduct.UnitPrice;
                    UnitStock = SelectedProduct.UnitStock;
                }
            }
        }

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

        public ProductViewModel()
        {
            LoadProductList();
        }

        void LoadProductList()
        {
           _ProductList = _ProductRepository.ReadAll();
        }

    }
}
