using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImportCSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Reading all the file for the first time
            ///*reading all file
            ///string csvAllText = System.IO.File.ReadAllText(@"C:\\Users\\c052108\\OneDrive - Yara International ASA\\Desktop\\VS Projects\Products.csv");
            
            //Read the file into lines
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\c052108\OneDrive - Yara International ASA\Desktop\VS Projects\Products.csv");

            ///First Attemp Using lists    
            ///* creating lists to store the values i've chopped from the lines
            ///- First Attemp:
            ///var productName = new List<string>();
            ///var productPrice = new List<double>();
           /// var productBrand = new List<string>();
           /// var productWeight = new List<double>();
            ///
            ///reading the lines and chopping them into colluns
            ///Like this it reads also the header, and we dont want that.
            ///for (int i = 0; i < csvLines.Length; i++)
            
            var products = new List<Products>();

            for (int i = 1; i < csvLines.Length; i++)
            {       
            ///First Attemp Using lists    
                    ///Adding the ellements i choopped on Lists;
                    ///string[] rawLines = csvLines[i].Split(',');
                    ///productName.Add(rawLines[0]);
                    /// double p = Convert.ToDouble(rawLines[1]);
                    ///productPrice.Add(p);
                    ///productBrand.Add(rawLines[2]);
                    ///double w = Convert.ToDouble(rawLines[3]);
                    ///productWeight.Add(w);*/
                    
                Products prod = new Products(csvLines[i]);
                products.Add(prod);

            }

            Console.WriteLine("Product Name | Product Price | Product Brand | Product Weight");

            for (int i = 0; i < products.Count; i++)
            {
                
                Console.WriteLine(products[i]);
            }

            /// First Attemp Using the Lists
            ///*Console.WriteLine("Product Name");
            ///for (int i = 0; i < productName.Count; i++)
            /// {
            ///     Console.WriteLine(productName[i]);
            /// }
            /// Console.WriteLine("Product Price");
            /// for (int i = 0; i < productPrice.Count; i++)
            /// {
            ///     Console.WriteLine(productPrice[i]);
            /// }           
            ///Console.WriteLine("Produc Brand");
            ///for (int i = 0; i < productBrand.Count; i++)
            ///{
            ///   Console.WriteLine(productBrand[i]);
            /// }   
            /// Console.WriteLine("Product Weight");
            /// for (int i = 0; i < productWeight.Count; i++)
            ///{
            ///     Console.WriteLine(productWeight[i]);
            /// }*/
            ///

            Console.WriteLine("Total of Products: " + products.Count) ;        
            Console.ReadKey();
        }
    }
}
