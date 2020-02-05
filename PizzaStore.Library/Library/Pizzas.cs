using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Library
{
   public class Pizzas
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Num { get; set; }

        public List<Topping> toppings;
    }
}
