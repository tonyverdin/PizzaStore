using Microsoft.EntityFrameworkCore;
using PizzaStore.DataAccess.Models;
using PizzaStore.Library;
using PizzaStore.Library.Interfaces;
using PizzaStore.Library.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PizzaStore.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly PizzaboxContext Context;
        protected readonly DbSet<TEntity> Entities;
        public Repository(PizzaboxContext context)
        {
            Context = context;

        }

        public TEntity Get(int id)
        {

            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {

            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);

        }

        public IEnumerable<Library.Library.Customer> GetCustomers()
        {
            var x = Context.Customer.Include(b=>b.AddressNavigation).Select(e=>Mapper.Map(e)).ToList();
            return x;

        }
        public Library.Library.Customer GetCustomerbyId(int id)
        {
            return Mapper.Map(Context.Customer.Include(a => a.AddressNavigation).FirstOrDefault(e => e.Id == id));

        }
        public Library.Library.Pizzas GetPizza(int id)
        {
            return Mapper.Map( Context.Pizza.Include(a=>a.PizzaIngredients).FirstOrDefault(e => e.Id == id));
            
        }

        public IEnumerable<Library.Library.Store> GetAllStores()
        {
            var x = Context.Store.Include(b => b.AddressNavigation).Select(e => Mapper.Map(e)).ToList();
            return x;
        }
        public Library.Library.Store GetStorebyId(int id)
        {
            var x = Context.Store.Include(b=>b.AddressNavigation).FirstOrDefault(e=>e.Id==id);
            return Mapper.Map(x);
        }
        public IEnumerable<Library.Library.Orders> GetOrdersbyStoreId(int id)
        {
            var x = Context.Orders.Where(a=>a.StoreId==id).Select(a=>Mapper.Map(a)).ToList();
            return x;

        }
        public IEnumerable<Library.Library.Orders> GetOrdersbyCustomerId(int id)
        {
            var x = Context.Orders.Where(a => a.CustomerId == id).Select(a => Mapper.Map(a)).ToList();
            return x;
        }
        public IEnumerable<Library.Library.Topping> GetToppingsbyPizzaId(int id)
        {
    
            var query = from i in Context.PizzaIngredients
                        where i.PizzaId == id
                        select i into z
                        join pi in Context.Ingredients on z.IngredientId equals pi.Id
                        select new Topping { Id = pi.Id,  Toppingname = pi.Topping, Type = pi.Type, Price = pi.Price };
            
            return query;
        }
        void IRepository<TEntity>.CreateCustomer(Library.Library.Customer customer)
        {
            Context.Loc.Add(Mapper.Map(customer.GetAddress()));
            Context.SaveChanges();
            customer.Id = (Context.Loc.Where(a => a.PhoneNumber == customer.Phonenum).Select(b => b.Id).FirstOrDefault());
            Context.Customer.Add(Mapper.Map(customer));
            Context.SaveChanges();
        }
    }
}
