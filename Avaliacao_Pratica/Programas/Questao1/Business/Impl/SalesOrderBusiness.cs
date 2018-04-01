using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Questao1.Business;
using Questao1.DataContext;
using Questao1.Models;

namespace Questao1.Business.Impl
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
    }
}
