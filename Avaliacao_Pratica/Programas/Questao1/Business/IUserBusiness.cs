using System;
using System.Collections.Generic;
using Questao1.Models;

namespace Questao1.Business
{
    public interface IUserBusiness: IBusiness
    {
        List<User> GetUsersWithSalesOrder();
        void CreateUser(User user);
    }
}
