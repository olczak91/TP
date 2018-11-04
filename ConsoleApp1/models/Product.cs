using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models
{
    
    public class Product
    {
        private int id;
        private string name;
        private string size;
        private string desc;

        public string Id
        {
            get => Id;
            set => Id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Size
        {
            get => size;
            set => size = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public override string ToString()
        {
            string s = "Produkt" + name + size + desc;
            return s;
           
        }

    }
}
