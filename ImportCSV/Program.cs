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
            ///Reading all the file for the first 
           //System.IO.File.ReadAllText(@"C:\Users\Marcelo & Ellen\source\repos\Marcelo---SDE\Products.            ///string csvAllText = csv");


            //Read the file into lines
            string[] csvLines = System.IO.File.ReadAllLines(@"C:\Users\Marcelo & Ellen\source\repos\Marcelo---SDE\Products.csv");

            ///Bringuing my Object Products Alive as a list
            var products = new List<Products>();
            

            //I'm puting a index counter to run all the lines of the file
            for (int i = 1; i < csvLines.Length; i++)
            {       
                // Here I'm bring up the object for everyline I have  
                //its going to isolate the line and sent line from line to the product object
                Products prod = new Products(csvLines[i]);   
                
                //This guy works so the program dont read empty lines as records
                if (prod.ProductBrand != null)

                //Finally, using the single line i isolated and passing to the Object product
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
