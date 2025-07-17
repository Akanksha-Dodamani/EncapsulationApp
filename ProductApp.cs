using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EncapsulationApp
{
    public class ProductApp
    {
        private int id;
        private string name;
        private double price;
        private readonly int DISCOUNT_PERCENTAGE = 20;

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public ProductApp(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public double CalculateDiscountedPrice()
        {
            return price - (price * DISCOUNT_PERCENTAGE / 100);
        }

        public void DisplayProductDetails(ProductApp product)
        {
            Console.WriteLine($"Product ID: {product.id}");
            Console.WriteLine($"Product Name: {product.name}");
            Console.WriteLine($"Original Price: {product.price}");
            Console.WriteLine($"Discounted Price with {DISCOUNT_PERCENTAGE}% Discount: {product.CalculateDiscountedPrice()}");
        }
    }
}
