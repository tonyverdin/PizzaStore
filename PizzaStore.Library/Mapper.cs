using PizzaStore.Library.Library;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PizzaStore.DataAccess.Models;

namespace PizzaStore.Library
{
   public class Mapper
    {
        public static Library.Store Map(DataAccess.Models.Store store)
        {
            return new Library.Store
            {
                Id = store.Id,
                Address1 = store.AddressNavigation.Address1,
                City = store.AddressNavigation.City,
                name = store.Name,
                State = store.AddressNavigation.State,
                PhoneNumber = store.AddressNavigation.PhoneNumber,
                Street = store.AddressNavigation.Street,

            };
        }
        public static Library.Orders Map(DataAccess.Models.Orders orders)
        {
            return new Library.Orders
            {
                Id = orders.Id,
                TotalPrice = orders.TotalPrice,
                PlaceDate = DateTime.Now,
                DeliveryDate = orders.DeliveryDate,
                StoreId = orders.StoreId,
                EmployeeId = orders.EmployeeId,
                CustomerId = orders.CustomerId,
            };
            
        }
        public static DataAccess.Models.Orders Map(Library.Orders orders)
        {
            return new DataAccess.Models.Orders
            {
                Id = orders.Id,
                TotalPrice = orders.TotalPrice,
                PlaceDate = DateTime.Now,
                DeliveryDate = orders.DeliveryDate,
                StoreId = orders.StoreId,
                EmployeeId = orders.EmployeeId,
                CustomerId = orders.CustomerId,
                
            };
        }
        public static Library.Customer Map(DataAccess.Models.Customer customer)
        {
            return new Library.Customer
            {
                Id = customer.Id,

                FirstName = customer.FirstName,
                LastName = customer.LastName,
                UserPassWord = customer.UserPassWord,

               Address1 = customer.AddressNavigation.Address1,
               State = customer.AddressNavigation.State,
               Phonenum = customer.AddressNavigation.PhoneNumber,
               City = customer.AddressNavigation.City,
               Street = customer.AddressNavigation.Street

            };

        }
        public static DataAccess.Models.Customer Map(Library.Customer customer)
        {
            return new DataAccess.Models.Customer
            {
                Id = customer.Id,
                FirstName=customer.FirstName,
                LastName=customer.LastName,
                UserPassWord = customer.UserPassWord
              
            };

        }


        public static DataAccess.Models.Loc Map(Address address)
        {
            return new DataAccess.Models.Loc
            { 
                Id = address.Id,
                City = address.City,
                State = address.City,
                Address1 = address.Address1,
                Street = address.Street,
                PhoneNumber= address.PhoneNumber

            };
        }

        public static Pizzas Map(DataAccess.Models.Pizza pizzas)
        {
            return new Pizzas
            {
                Id = pizzas.Id,
                Num = pizzas.Num,
                OrderId = pizzas.OrderId,
                
                
            };


        }

        public static Topping Map(PizzaIngredients ingredients)
        {
            return new Topping
            {
                Id = ingredients.Id,
                Toppingname = ingredients.Ingredient.Topping,
                Price =ingredients.Ingredient.Price,
                Amount = ingredients.Ingredient.Amount,
                Type = ingredients.Ingredient.Type,

            };
            
        }
    }
}
