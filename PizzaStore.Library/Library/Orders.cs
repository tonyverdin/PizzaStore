using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Library
{
    public class Orders
    {
        public int Id { get; set; }
        public decimal? TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public DateTime? PlaceDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? StoreId { get; set; }
        public int? EmployeeId { get; set; }
        public int? CustomerId { get; set; }
        List<Pizzas> PizzaList;
    }
}
