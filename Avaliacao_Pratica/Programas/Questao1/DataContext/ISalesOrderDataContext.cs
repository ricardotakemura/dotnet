using System;
using System.Collections.Generic;
using Questao1.Models;

namespace Questao1.DataContext
{
    public interface ISalesOrderDataContext
    {
        List<SalesOrder> GetSalesOrders();
    }
}
