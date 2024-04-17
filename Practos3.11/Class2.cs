using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practos3._11
{
    internal class Class2
    {
        public int Order_Product {  get; set; }

        public int order_id { get; set;}

        public int product_id { get; set;}

        public int quantity { get; set;}

        public int products_id { get; set;}

        public string product_name { get; set;}

        public int price { get; set;}

        public int stock_quantity { get; set;}



        public Class2(Order_Products order_Pro) { 
            Order_Product = order_Pro.Order_Product;
            order_id = (int)order_Pro.order_id;
            product_id = (int)order_Pro.products_id;
            quantity = (int)order_Pro.quantity;
            if(Order_Product != null)
            {
                products_id = order_Pro.Products.product_id;
                product_name = order_Pro.Products.product_name;
                price = (int)order_Pro.Products.price;
                stock_quantity = (int)order_Pro.Products.stock_quantity;

            }

        }
    }
}
