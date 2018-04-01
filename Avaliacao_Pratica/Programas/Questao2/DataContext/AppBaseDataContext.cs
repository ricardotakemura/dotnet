using Microsoft.EntityFrameworkCore;
using Questao2.Models;

namespace Questao2.DataContext
{
    public class AppBaseDataContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=questao1.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
