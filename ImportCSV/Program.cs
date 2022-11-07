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
            //string csvAllText = System.IO.File.ReadAllText(@"C:\\Users\\c052108\\OneDrive - Yara International ASA\\Desktop\\VS Projects\Products.csv");
            Console.Title = "CSV IMPORTER";
            Console.WriteLine("**************CSV Importer**************");
            Console.WriteLine();
            Console.WriteLine("Please imput the file path:");
            Console.WriteLine();
            Console.ReadKey();
            var filePath = Console.ReadLine();

            //Read the file into lines
            string[] csvLines = System.IO.File.ReadAllLines("C" + filePath);

            ///Bringuing my Object Products Alive as a list
            var products = new List<Products>();
            

            //I'm puting a index counter to run all the lines of the file
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
