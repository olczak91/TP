using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models
{
    class States
    {

        private bool available;
        private int quantity;
        private double price;
        private double tax;
        private Product product;

        public bool Available
        {
            get => available;
            set => available = value;
        }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
        public double Price
        {
            get => price;
            set => price = value;
        }

        public double Tax
        {
            get => tax;
            set => tax = value;
        }

        public Product Product
        {
            get => product;
            set => product = value;
        }
    }

}
