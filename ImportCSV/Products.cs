using System;

namespace ImportCSV
{
    public class Products
    {
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }

        public double ProductPrice { get; set; }
        public double ProductWeight { get; set; }


        //The main class method is returning a string array of csvLines
        //This way i can select line from line, and start choppinh each elemrnt separated by comma;
        public Products(string csvLines)
        {
            //using the split method and saying to the program to 
            string[] data = csvLines.Split(',');

                //addig the parts chopped into my class properties
                //using the try cacth to treat some issues because i have numbers and chars on the info.
                try
                {
                    ProductName = data[0];
                }
                catch { }

                try
                {
                    ProductPrice = Convert.ToDouble(data[1]);
                }
                catch { }

                try
                {                   
                    ProductBrand = data[2];
                }
                catch { }

                try
                {
                    ProductWeight = Convert.ToDouble(data[3]);
                }
                catch { }
            
        }

        //I used the override method where so all when I ask the main 
        //class to print the product List, the method will do this for all the products.
        //make it easier to print on screen;
        public override string ToString()
        {

            string str = $"Product Info:" + $"\n" + 
                $"Description:{ProductName} " + $"\n" +
                $"Price: ${ProductPrice} " + $"\n" +
                $"Brand: {ProductBrand} " + $"\n" +
                $"Weight: {ProductWeight}" + $"\n";
            return str;
        }

    }
}
