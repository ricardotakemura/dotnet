using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Questao1.DataContext;
using Questao1.Models;

namespace Questao1.DataContext
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
