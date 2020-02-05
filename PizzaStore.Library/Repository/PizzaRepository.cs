using PizzaStore.DataAccess.Models;
using PizzaStore.DataAccess.Repositories;
using PizzaStore.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Repository
{
    class PizzaRepository:Repository<Pizza>, IPizza
    {
        public PizzaRepository(PizzaboxContext context)
: base(context)
        {
        }
        public PizzaboxContext PizzaBoxContext
        {
            get { return Context as PizzaboxContext; }
        }
    }
}
