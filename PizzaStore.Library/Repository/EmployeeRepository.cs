using PizzaStore.DataAccess.Models;
using PizzaStore.DataAccess.Repositories;
using PizzaStore.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.DataAccess.Repository
{
    class EmployeeRepository: Repository<Employee>, IEmployee
    {

            public EmployeeRepository(PizzaboxContext context)
    : base(context)
            {
            }
            public PizzaboxContext PizzaboxContext
            {
                get { return Context as PizzaboxContext; }
            }
        }
    
}
