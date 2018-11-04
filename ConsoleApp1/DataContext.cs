using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using models;

namespace ConsoleApp1
{
  

    class DataContext
    {
        public Dictionary<int, Product> products;

        public List<Client> clients;

        public ObservableCollection<Orders> orders;

        public List<States> states;

        public DataContext() 
        {
            products = new Dictionary<int, Product>();
            clients = new List<Client>();
            orders = new ObservableCollection<Orders>();
            states = new List<States>();
        }
    }
}
