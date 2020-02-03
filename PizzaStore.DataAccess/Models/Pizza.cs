using System;
using System.Collections.Generic;

namespace PizzaStore.DataAccess.Models
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaIngredients = new HashSet<PizzaIngredients>();
        }

        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Num { get; set; }

        public virtual Orders Order { get; set; }
        public virtual ICollection<PizzaIngredients> PizzaIngredients { get; set; }
    }
}
