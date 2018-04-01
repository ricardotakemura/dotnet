using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Questao1.Business;
using Questao1.DataContext;
using Questao1.Models;

namespace Questao1.Business.Impl
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

        public void CreateUser(User user) 
        {
            using (var context = new UserDataContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
