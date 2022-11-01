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

    }
}
