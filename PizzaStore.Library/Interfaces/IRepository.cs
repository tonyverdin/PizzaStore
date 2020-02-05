using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace PizzaStore.Library.Interfaces
    {
        public interface IRepository<TEntity> where TEntity : class
        {
            TEntity Get(int id);
            IEnumerable<TEntity> GetAll();
            IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

            TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

            void Add(TEntity entity);
            void AddRange(IEnumerable<TEntity> entities);

            void Remove(TEntity entity);
            void RemoveRange(IEnumerable<TEntity> entities);
            public IEnumerable<Library.Customer> GetCustomers();
            public Library.Customer GetCustomerbyId(int id);
            public Library.Pizzas GetPizza(int id);
            public IEnumerable< Library.Store> GetAllStores();
            public Library.Store GetStorebyId(int id);
            public IEnumerable<Library.Orders> GetOrdersbyStoreId(int id);
            public IEnumerable<Library.Orders> GetOrdersbyCustomerId(int id);
            public IEnumerable<Library.Topping> GetToppingsbyPizzaId(int id = 2);
            void CreateCustomer (Library.Customer customer);
    }
}
