using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Practos3._11
{
    internal class Class1
    {

        internal class Class11
        {
            public int delivery_id {  get; set; }
            public int order_id { get; set; }
            public string delivery_status { get; set; }

            public DateTime estimated_delivery_date { get; set; }

            public string product_name { get; set; }

            public  decimal total_amount { get; set; }
            
            public DateTime order_data { get; set; }

           


            public Class11(Delivery delivery)
            {   
                delivery_id = delivery.delivery_id;
                delivery_status = delivery.delivery_status;
                
                if (delivery.Orders != null)
                {
                    order_id = delivery.Orders.order_id;
                    total_amount = (decimal)delivery.Orders.total_amount;
                    order_data = (DateTime)delivery.Orders.order_date;
                    estimated_delivery_date = (DateTime)delivery.estimated_delivery_date;

                }
               
            }
        }



    }

}
