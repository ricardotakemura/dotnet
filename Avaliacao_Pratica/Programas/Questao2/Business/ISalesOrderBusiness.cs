using System.Collections.Generic;
using Questao2.Models;

namespace Questao2.Business
{
    public interface ISalesOrderBusiness: IBusiness
    {
        List<SalesOrder> GetSalesOrderByUser(User user);
        List<SalesOrder> GetSalesOrders();
        SalesOrder GetSalesOrder(string salesOrderNumber);
        void InsertSalesOrder(SalesOrder salesOrder);
        void DeleteSalesOrder(SalesOrder salesOrder);
        void UpdateSalesOrder(SalesOrder salesOrder);
    }
}
