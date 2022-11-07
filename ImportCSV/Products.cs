using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportCSV
{
    public class Products
    {
        public string ProductName,
                      ProductBrand;

        public double ProductPrice,
                      ProductWeight;

        public Products(string csvLines)
        {
            string[] data = csvLines.Split(',');

            //addig the parts chopped into my class properties
            ProductName = data[0];
            ProductPrice = Convert.ToDouble(data[1]);
            ProductBrand = data[2];
            ProductWeight = Convert.ToDouble(data[3]);

        }

        public override string ToString()
        {

            string str = $"{ProductName} | {ProductPrice} | {ProductBrand} | {ProductWeight}";              
            return str;
        }

    }
}
