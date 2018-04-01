using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Questao2.Business;
using Questao2.DataContext;
using Questao2.Models;

namespace Questao2.Business.Impl
{
    public class UserBusiness: IUserBusiness
    {
        public List<User> GetUsersWithSalesOrder()
        {
            ISalesOrderBusiness salesOrderBusiness = BusinessFactory.GetInstance().CreateBusiness<SalesOrderBusiness>();
            using (var context = new UserDataContext())
            {
                foreach (var user in context.Users) {
                    user.SalesOrders = salesOrderBusiness.GetSalesOrderByUser(user);   
                }
                return context.Users.ToList();
            }
        }

        public void InsertUser(User user) 
        {
            using (var context = new UserDataContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public User GetUser(int userId)
        {
            ISalesOrderBusiness salesOrderBusiness = BusinessFactory.GetInstance().CreateBusiness<SalesOrderBusiness>();
            using (var context = new UserDataContext()) 
            {
                var user = (from u in context.Users where u.Id == userId select u).First();
                return user;
            }
        }

        public void DeleteUser(User user)
        {
            using (var context = new UserDataContext())
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public void UpdateUser(User user)
        {
            using (var context = new UserDataContext())
            {
                context.Update(user);
                context.SaveChanges();
            }
        }

    }
}
