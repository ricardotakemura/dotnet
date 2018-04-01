using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Questao2.Business;
using Questao2.DataContext;
using Questao2.Models;

namespace Questao2.Business.Impl
{
    public class SalesOrderBusiness: ISalesOrderBusiness
    {
        public List<SalesOrder> GetSalesOrderByUser(User user)
        {
            using (var context = new SalesOrderDataContext())
            {
                var salesOrders = from s in context.SalesOrders where s.UserId == user.Id select s;
                return salesOrders.ToList();
            }
        }

        public List<SalesOrder> GetSalesOrders() 
        {
            using (var context = new SalesOrderDataContext())
            {
                return context.SalesOrders.ToList();
            }
        }


        public SalesOrder GetSalesOrder(string salesOrderNumber) 
        {
            using (var context = new SalesOrderDataContext())
            {
                var saleOrder = (from s in context.SalesOrders where s.SalesOrderNumber == salesOrderNumber select s).First();
                var userBusiness = BusinessFactory.GetInstance().CreateBusiness<UserBusiness>();
                saleOrder.User = userBusiness.GetUser(saleOrder.UserId);
                return saleOrder;
            }
        }

        public void InsertSalesOrder(SalesOrder salesOrder)
        {
            using (var context = new SalesOrderDataContext()) {
                context.SalesOrders.Add(salesOrder);
                context.SaveChanges();
            }
        }

        public void DeleteSalesOrder(SalesOrder salesOrder)
        {
            using (var context = new SalesOrderDataContext())
            {
                context.SalesOrders.Remove(salesOrder);
                context.SaveChanges();
            }
        }

        public void UpdateSalesOrder(SalesOrder salesOrder)
        {
            using (var context = new SalesOrderDataContext())
            {
                context.Update(salesOrder);
                context.SaveChanges();
            }
        }

    }
}
