using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Questao1.DataContext;
using Questao1.Models;

namespace Questao1.DataContext
{
    public class SalesOrderDataContext: AppBaseDataContext
    {
        public DbSet<SalesOrder> SalesOrders { get; set; }
    }
}
