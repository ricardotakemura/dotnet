using System;

using System.Collections.Generic;
using Questao1.Models;

namespace Questao1.Business
{
    public interface ISalesOrderBusiness: IBusiness
    {
        List<SalesOrder> GetSalesOrderByUser(User user);
    }
}
