using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPart2
{
    internal class Order
    {
        public int OrderID { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int id, int orderQuantity)
        {
            this.OrderID = id;
            this.OrderQuantity = OrderQuantity;
        }

        //print message on the screen that the order was processed
        public void ProcessOrder()
        {
            //print the message
            Console.WriteLine($"Order {OrderID} processed!");
            Console.WriteLine("*****************************************");
        }
    }
}
