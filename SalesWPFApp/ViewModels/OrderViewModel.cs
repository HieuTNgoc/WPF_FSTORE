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

namespace SalesWPFApp.ViewModels
{
    public class OrderViewModel
    {
        public ICommand searchCommand { get; set; }
        public ICommand createCommand { get; set; }
        public ICommand updateCommand { get; set; }
        public ICommand deleteCommand { get; set; }

      
        public OrderViewModel()
        {
          

        }
        //public void loadCommand()
        //{
        //    searchCommand = new RelayCommand<Object>(p => true, p =>
        //    {


        //    });
        //    createCommand = new RelayCommand<UIElementCollection>(p => true, p =>
        //    {
        //        int MemberId = 0;
        //        DateTime Orderdate = DateTime.Now;
        //        DateTime RequireDate = DateTime.Now;
        //        DateTime ShippedDate = DateTime.Now;
        //        decimal Freight = 0;
        //        Boolean isAllValid = true;
        //        try
        //        {
        //            foreach (var i in p)
        //            {
        //                TextBox tb = i as TextBox;
        //                if (tb != null)
        //                {

        //                    switch (tb.Name)
        //                    {

        //                        case "MemberId":
        //                            MemberId = Int32.Parse(tb.Text);
        //                            break;
        //                        case "Orderdate":
        //                            Orderdate = DateTime.Parse(tb.Text);
        //                            break;
        //                        case "RequiredDate":
        //                            RequireDate = DateTime.Parse(tb.Text);
        //                            break;
        //                        case "ShippedDate":
        //                            ShippedDate = DateTime.Parse(tb.Text);
        //                            break;
        //                        case "Freight":
        //                            Freight = decimal.Parse(tb.Text);
        //                            break;
        //                    }


        //                }

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            isAllValid = false;
        //        }
        //        if (isAllValid == true)
        //        {
        //            orderDAO.add(new Order(MemberId,
        //                Orderdate, RequireDate, ShippedDate, Freight));
        //            loadOrderList();
        //        }
        //        else
        //            return;
        //    });
        //    updateCommand = new RelayCommand<UIElementCollection>(p => true, p =>
        //    {
        //        int OrderId = 0;
        //        int MemberId = 0;
        //        DateTime Orderdate = DateTime.Now;
        //        DateTime RequireDate = DateTime.Now;
        //        DateTime ShippedDate = DateTime.Now;
        //        decimal Freight = 0;
        //        Boolean isAllValid = true;
        //        try
        //        {
        //            foreach (var i in p)
        //            {
        //                TextBox tb = i as TextBox;
        //                if (tb != null)
        //                {

        //                    switch (tb.Name)
        //                    {
        //                        case "OrderId":
        //                            OrderId = Int32.Parse(tb.Text);
        //                            break;
        //                        case "MemberId":
        //                            MemberId = Int32.Parse(tb.Text);
        //                            break;
        //                        case "Orderdate":
        //                            Orderdate = DateTime.Parse(tb.Text);
        //                            break;
        //                        case "RequireDate":
        //                            RequireDate = DateTime.Parse(tb.Text);
        //                            break;
        //                        case "ShippedDate":
        //                            ShippedDate = DateTime.Parse(tb.Text);
        //                            break;
        //                        case "Freight":
        //                            Freight = decimal.Parse(tb.Text);
        //                            break;
        //                    }
        //                }

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            isAllValid = false;
        //        }
        //        if (isAllValid == true)
        //        {
        //            orderDAO.update(OrderId, new Order(OrderId, MemberId,
        //                Orderdate, RequireDate, ShippedDate, Freight));
        //            loadOrderList();
        //        }
        //        else
        //            return;
        //    });
        //    deleteCommand = new RelayCommand<Object>(p => true, p =>
        //    {
        //        Order o = p as Order;
        //        if (o != null)
        //        {
        //            orderDAO.delete(o);
        //            loadOrderList();
        //        }
        //        else return;
        //    });
        //}
        //public void loadOrderList()
        //{
        //    orderList.Clear();
        //    List<Order> orders = orderDAO.getAll();
        //    foreach (Order order in orders)
        //        orderList.Add(order);
        //}
    }
}
