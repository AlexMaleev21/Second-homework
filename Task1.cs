using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public class Money
    {
        private double intPart;

        public double IntPart {
            get
            {
                return intPart;
            }
            set
            {
                if (value >= 0)
                {
                    intPart = value;
                }
            }
        }

        private double decimalPart;

        public double DecimalPart {
            get
            {
                return decimalPart;
            }
            set
            {
                if(value > 0 && value < 100)
                {
                    decimalPart = value;
                }
            }
        }
        public double fullNumber { get; set; }

        public Money(double firstPart, double secondPart)
        {
            IntPart = firstPart;
            DecimalPart = secondPart;
            fullNumber = IntPart + DecimalPart/100;
        }

        public void ShowFullNumber()
        {
            Console.WriteLine($"Full number: {fullNumber}");
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public Money Price { get; set; }
        public Product (string name, Money price)
        {
            ProductName = name;
            Price = price;
        }
        public void ShowProductName()
        {
            Console.WriteLine($"Product name: {ProductName}");
        }
        public void ApplyDiscount(int discount)
        {
            Price.fullNumber -= Price.fullNumber * discount / 100;
            Price.fullNumber = Math.Round(Price.fullNumber, 2);
        }
    }
    internal class Task1
    {
        Product phone = new Product("Iphone 15", new Money(999, 99));
        public void TestTask1()
        {
            phone.ShowProductName();
            phone.Price.ShowFullNumber();
            phone.ApplyDiscount(25);
            phone.Price.ShowFullNumber();
        }
    }

    
}
