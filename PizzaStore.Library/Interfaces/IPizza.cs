using PizzaStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Library.Interfaces
{
    public interface IPizza: IRepository<Pizza>
    {
    }
}
