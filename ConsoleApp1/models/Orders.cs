using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models
{
    public class Orders
    {
        private int id;
        private DateTimeOffset dateOfPurchase;
        private int quantity;
        private Product product;
        
        public int Id
        {
            get => id;
            set => id = value;
        }

        public DateTimeOffset DateOfPurchase
        {
            get => dateOfPurchase;
            set => dateOfPurchase = value;
        }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
        
        public Product Product
        {
            get => product;
            set => product = value;
        }
    }
}
