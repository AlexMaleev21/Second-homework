using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2
{
    public struct DecimalNumber
    {
        private int decimalNumber;
        public DecimalNumber(int decimalNumber)
        {
            this.decimalNumber = decimalNumber;
        }

        public override string ToString()
        {
            return decimalNumber.ToString();
        }

        public void convertToBinary()
        {
            Console.WriteLine(Convert.ToString(decimalNumber, 2));
        }

        public void convertToOct()
        {
            Console.WriteLine(Convert.ToString(decimalNumber, 8));
        }

        public void convertToHex()
        {
            Console.WriteLine(Convert.ToString(decimalNumber, 16));
        }
    }
    internal class Task3
    {
        DecimalNumber decimalNumber = new DecimalNumber(10);
        
        public void TestTask3()
        {
            decimalNumber.convertToBinary();
            decimalNumber.convertToOct();
            decimalNumber.convertToHex();
        }
    }
}
