using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductApp.Models
{
    internal class Product
    {
        private int _id;
        private string _productName;
        private double _price;
        private double _discountPercent;

        public int Id{    set { _id = value; } get { return _id; }       }
        public string ProductName { set { _productName = value; } get { return _productName; } }

        public double Price { set { _price = value; } get { return _price; } }

        public double DiscountPercent { set { _discountPercent = value; } get { return _discountPercent; } }

        public double CalculateNewPrice()
        {
              return _price - (_price * (_discountPercent/100));  
        }
    }
}
