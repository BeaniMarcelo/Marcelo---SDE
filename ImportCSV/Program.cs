using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


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

            var products = new List<Products>();

            for (int i = 1; i < csvLines.Length; i++)
            {       
                    
                Products prod = new Products(csvLines[i]);               
                if (prod.ProductBrand != null)
                products.Add(prod);

            }

            for (int i = 0; i < products.Count; i++)
            {
                
                Console.WriteLine(products[i]);
            }

            Console.WriteLine("Total of Products: " + products.Count) ;        
            Console.ReadKey();
        }
    }
}
