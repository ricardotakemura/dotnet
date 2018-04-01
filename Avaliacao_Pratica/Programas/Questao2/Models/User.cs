using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Questao2.Models
{
    [Table("Users")]
    public class User
    {
        public User() {}

        public User(int id, string name, List<SalesOrder> salesOrders)
        {
            this.Id = id;
            this.Name = name;
            this.SalesOrders = salesOrders;
        }

        public string Name { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}

        public List<SalesOrder> SalesOrders { get; set; }

		public override string ToString()
		{
            var ret = string.Format("{0}\n", Name);
            foreach (var salesOrder in SalesOrders) {
                ret += string.Format("-- {0}\n", salesOrder);
            }
            return ret;
		}
	}
}
