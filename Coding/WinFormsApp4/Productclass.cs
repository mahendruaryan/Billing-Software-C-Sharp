using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
namespace WinFormsApp4
{
   
    internal class Product
    {
       public string Id { get; set; }
       public string Name { get; set; }
       public string Price { get; set; }
        
        public Product(string id,string name,string price){
            this.Id = id;
            this.Name = name;
            this.Price = price;

        }

        public static List<Product> items = new List<Product>();//list for presaved products  


        public static string NextProductID(List<Product> products)//function to genrate next product id
        {
            if (products.Count > 0)//if atleast one product is present in list 
            {
                int lastindex = products.Count - 1;//getting last index
                int lastproid = Int32.Parse(products[lastindex].Id);
                string newproid = Convert.ToString(lastproid + 1);

                return newproid;
            }

            return "1";//if no item is prsent in the list this would be the first item

        }
        public static void SaveData(List<Product> products)//method to save data 
        {
            // convert list of users to JSON string
            string jsonString = JsonSerializer.Serialize(products);

            // write JSON string to a file
            File.WriteAllText("Products.json", jsonString);
        }




    }

}
