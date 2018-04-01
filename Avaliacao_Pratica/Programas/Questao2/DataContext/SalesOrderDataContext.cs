using Microsoft.EntityFrameworkCore;
using Questao2.Models;

namespace Questao2.DataContext
{
    public class SalesOrderDataContext: AppBaseDataContext
    {
        public DbSet<SalesOrder> SalesOrders { get; set; }
    }
}
