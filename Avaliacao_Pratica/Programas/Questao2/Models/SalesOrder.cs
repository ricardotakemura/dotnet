using System.ComponentModel.DataAnnotations;

namespace Questao2.Models
{
    [Table("SalesOrders")]
    public class SalesOrder
    {
        public SalesOrder() {}

        public SalesOrder(string salesOrderNumber, double totalValue, int itensCount, int userId)
        {
            this.SalesOrderNumber = salesOrderNumber;
            this.TotalValue = totalValue;
            this.ItensCount = itensCount;
            this.UserId = userId;
        }

        [Key]
        public string SalesOrderNumber { get; set; }

        public double TotalValue { get; set; }

        public int ItensCount { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

		public override string ToString()
		{
            return string.Format("{0}, {1}, {2}", SalesOrderNumber, TotalValue, ItensCount);
		}

	}
}
