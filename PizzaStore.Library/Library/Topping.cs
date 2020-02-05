using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Library
{
   public class Topping
    {
        public int Id { get; set; }
        public string Toppingname { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Type { get; set; }
    }
}
