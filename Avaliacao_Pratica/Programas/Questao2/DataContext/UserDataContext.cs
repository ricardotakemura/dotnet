using Microsoft.EntityFrameworkCore;
using Questao2.Models;

namespace Questao2.DataContext
{
    public class UserDataContext: AppBaseDataContext
    {
        public DbSet<User> Users { get; set; }
    }
}
