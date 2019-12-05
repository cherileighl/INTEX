using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwestLabsApp.Models
{
    public class OrdersAndStatusesView
    {
        public IEnumerable<Orders> EnumOrders { get; set; }
        public IEnumerable<Order_Statuses> EnumOrderStatuses { get; set; }

        public OrdersAndStatusesView() { }
        public OrdersAndStatusesView(IEnumerable<Orders> enumOrders, IEnumerable<Order_Statuses> enumOrderStatuses)
        {
            this.EnumOrders = enumOrders;
            this.EnumOrderStatuses = enumOrderStatuses;
        }
    }
}