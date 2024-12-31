using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class Buying
    {
        public string Name { get; set; }
        public int Unitprice { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }


        public Buying(string name, int unitprice, int quantity, int price)
        {
            this.Name = name;
            this.Unitprice = unitprice;
            this.Quantity = quantity;
            Price = price;
        }
        public static BindingList<Buying> shoppingcart = new BindingList<Buying>();  //binding list for cart of the user 
    }
}
